﻿'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Public Class EntriesComparer : Implements IComparer(Of Objects.VoucherEntry)

#Region "Properties/Fields"
    ReadOnly Property Voucher As Objects.Voucher
#End Region

#Region "Constructor"
    Sub New(ByVal Voucher As Objects.Voucher)
        Me.Voucher = Voucher
    End Sub
#End Region

#Region "Public Functions"
    Public Function Compare(x As Objects.VoucherEntry, y As Objects.VoucherEntry) As Integer Implements IComparer(Of Objects.VoucherEntry).Compare
        If String.Compare(Voucher.VoucherType, "Payment") = 0 Or String.Compare(Voucher.VoucherType, "Journal") = 0 Or String.Compare(Voucher.VoucherType, "Sales") = 0 Then
            Return Compare_DrFirst(x, y) ' Debit Entries Should be Placed First in Payment, Journal, Sales Vouchers
        Else
            Return Compare_CrFirst(x, y)  ' Credit Entries Should be Placed First in All Other Vouchers
        End If
    End Function
#End Region

#Region "Private Functions"
    Private Function Compare_DrFirst(x As Objects.VoucherEntry, y As Objects.VoucherEntry) As Integer
        If String.Compare(Voucher.VoucherType, "Sales", True) = 0 AndAlso Utils.Settings.Load.UseInvoiceSales AndAlso (String.Compare(x.LedgerName, Utils.Settings.Load.RoundOffLedger, True) = 0 Or String.Compare(y.LedgerName, Utils.Settings.Load.RoundOffLedger, True) = 0) Then
            Return isRounding(x, y)
        End If

        If x.Effect = y.Effect Then
            ' RoundingOff Ledger Should be Placed in Last
            Return isRounding(x, y)
        ElseIf x.Effect < y.Effect Then
            Return -1
        ElseIf x.Effect > y.Effect Then
            Return 1
        End If
        Return 0
    End Function

    Private Function Compare_CrFirst(x As Objects.VoucherEntry, y As Objects.VoucherEntry) As Integer
        If String.Compare(Voucher.VoucherType, "Purchase", True) = 0 AndAlso Utils.Settings.Load.UseInvoicePurchase AndAlso (String.Compare(x.LedgerName, Utils.Settings.Load.RoundOffLedger, True) = 0 Or String.Compare(y.LedgerName, Utils.Settings.Load.RoundOffLedger, True) = 0) Then
            Return isRounding(x, y)
        End If

        If x.Effect = y.Effect Then
            ' RoundingOff Ledger Should be Placed in Last
            Dim R As Integer = isRounding(x, y)
            If R = 0 Then
                R = x.Amount.CompareTo(y.Amount) * -1
            End If
            Return R
        ElseIf x.Effect < y.Effect Then
            Return 1
        ElseIf x.Effect > y.Effect Then
            Return -1
        End If
        Return 0
    End Function

    Private Function isRounding(x As Objects.VoucherEntry, y As Objects.VoucherEntry) As Integer
        If String.Compare(x.LedgerName, Utils.Settings.Load.RoundOffLedger, True) = 0 Then
            Return 1
        ElseIf String.Compare(y.LedgerName, Utils.Settings.Load.RoundOffLedger, True) = 0 Then
            Return -1
        End If
        Return 0
    End Function
#End Region

End Class