Imports EntityFrameworkCoreLibrary.Models
Imports Microsoft.EntityFrameworkCore.Metadata.Builders
Imports Microsoft.EntityFrameworkCore

Namespace EntityFrameworkCoreLibrary.Contexts
    Public Class ContactTypeConfiguration
        Implements IEntityTypeConfiguration(Of ContactType)

        Public Sub Configure(entity As EntityTypeBuilder(Of ContactType)) _
            Implements IEntityTypeConfiguration(Of ContactType).Configure

            entity.HasKey(Function(e) e.ContactTypeIdentifier)

        End Sub
    End Class
End Namespace
