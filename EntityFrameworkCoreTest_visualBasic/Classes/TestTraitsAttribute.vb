Option Infer On

Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace EntityFrameworkCoreTest.Classes
    ''' <summary>
    ''' Add traits here
    ''' </summary>
    Public Enum Trait
        EncryptDecryptConnectionString
        EnvironmentConnections
    End Enum

    Public Class TestTraitsAttribute
        Inherits TestCategoryBaseAttribute

        Private traits() As Trait

        Public Sub New(ParamArray ByVal traits() As Trait)
            Me.traits = traits
        End Sub

        Public Overrides ReadOnly Property TestCategories() As IList(Of String)
            Get
                Dim traitStrings = New List(Of String)()

                For Each trait In traits
                    Dim value As String = System.Enum.GetName(GetType(Trait), trait)
                    traitStrings.Add(value)
                Next trait

                Return traitStrings
            End Get
        End Property
    End Class
End Namespace
