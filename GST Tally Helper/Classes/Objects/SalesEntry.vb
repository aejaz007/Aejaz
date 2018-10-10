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
'                                                                          '
'=========================================================================='

Namespace Objects
    Public Class SalesEntry

#Region "Properties/Fields"
        Property GSTIN As String
        Property InvoiceDate As Date
        Property InvoiceNumber As String
        Property InvoiceValue As Double
        Property Rate As Integer
        Property TaxableValue As Double
        Property IGST As Double
        Property CGST As Double
        Property SGST As Double
#End Region

#Region "Constructors"
        Sub New()
            Me.GSTIN = ""
            Me.InvoiceDate = Now
            Me.InvoiceNumber = ""
            Me.InvoiceValue = 0
            Me.Rate = 0
            Me.TaxableValue = 0
            Me.IGST = 0
            Me.CGST = 0
            Me.SGST = 0
        End Sub

        Sub New(ByVal GSTIN As String, ByVal InvoiceDate As Date, ByVal InvoiceNumber As String, ByVal InvoiceValue As Double,
                ByVal Rate As Integer, ByVal TaxableValue As Double, ByVal IGST As Double, ByVal CGST As Double, ByVal SGST As Double)
            Me.GSTIN = GSTIN
            Me.InvoiceDate = InvoiceDate
            Me.InvoiceNumber = InvoiceNumber
            Me.InvoiceValue = InvoiceValue
            Me.Rate = Rate
            Me.TaxableValue = TaxableValue
            Me.IGST = IGST
            Me.CGST = CGST
            Me.SGST = SGST
        End Sub
#End Region

    End Class
End Namespace