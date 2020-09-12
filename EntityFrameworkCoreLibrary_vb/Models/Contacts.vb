Namespace EntityFrameworkCoreLibrary.Models
    Partial Public Class Contacts
        ''' <summary>
        ''' Id
        ''' </summary>
        Public Property ContactId() As Integer
        ''' <summary>
        ''' First name
        ''' </summary>
        Public Property FirstName() As String
        ''' <summary>
        ''' Last name
        ''' </summary>
        Public Property LastName() As String
        ''' <summary>
        ''' Contact Type Id
        ''' </summary>
        Public Property ContactTypeIdentifier() As Integer?

        Public Overridable Property ContactTypeIdentifierNavigation() As ContactType
    End Class
End Namespace