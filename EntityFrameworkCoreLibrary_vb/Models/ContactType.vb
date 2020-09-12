Namespace EntityFrameworkCoreLibrary.Models
    Partial Public Class ContactType
        Public Sub New()
            Contacts = New HashSet(Of Contacts)()
        End Sub

        Public Property ContactTypeIdentifier() As Integer
        Public Property ContactTitle() As String

        Public Overridable Property Contacts() As ICollection(Of Contacts)
    End Class
End Namespace