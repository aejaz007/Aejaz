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

Imports DevExpress.XtraEditors.DXErrorProvider

Public Class Party : Implements IDXDataErrorInfo

#Region "Properties/Fields"
    Property Name As String
        Property GSTIN As String
        Property Group As Enums.PartyType
        Property RegType As Enums.RegistrationType
        ReadOnly Property State As State
            Get
                Try
                    Dim StateCode As Integer = CInt(GSTIN.Substring(0, 2))
                    Return State.GetStateByCode(StateCode)
                Catch ex As Exception
                    Return State.GetStateByCode(Utils.Settings.Load.StateCode)
                End Try
            End Get
        End Property
#End Region

#Region "Constructors"
        Sub New()
            Me.Name = ""
            Me.GSTIN = ""
            Me.Group = Enums.PartyType.SundryDebtor
            Me.RegType = Enums.RegistrationType.Unknown
        End Sub

        Sub New(ByVal Name As String, ByVal GSTIN As String, ByVal RegType As Enums.RegistrationType, ByVal Group As Enums.PartyType)
            Me.Name = Name
            Me.GSTIN = GSTIN
            Me.Group = Group
            Me.RegType = RegType
        End Sub
#End Region

#Region "Subs"
        Public Sub GetPropertyError(propertyName As String, info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            If propertyName = "GSTIN" AndAlso GSTIN <> "" Then
                Try
                Utils.GSTINValidator.Validate(GSTIN)
            Catch ex As Exception
                    info.ErrorText = ex.Message
                    info.ErrorType = ErrorType.Warning
                End Try
            End If
        End Sub

        Public Sub GetError(info As ErrorInfo) Implements IDXDataErrorInfo.GetError
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Name
        End Function
#End Region

End Class