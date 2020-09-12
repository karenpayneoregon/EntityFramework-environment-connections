Imports EntityFrameworkCoreLibrary.Models
Imports Microsoft.EntityFrameworkCore.Metadata.Builders
Imports Microsoft.EntityFrameworkCore

Namespace EntityFrameworkCoreLibrary.Contexts
	Public Class ContactsConfiguration
		Implements IEntityTypeConfiguration(Of Contacts)

        Public Sub Configure(entity As EntityTypeBuilder(Of Contacts)) _
            Implements IEntityTypeConfiguration(Of Contacts).Configure

            entity.HasKey(Function(e) e.ContactId)

            entity.Property(Function(e) e.ContactId).
                HasComment("Id")

            entity.Property(Function(e) e.ContactTypeIdentifier).
                HasComment("Contact Type Id")

            entity.Property(Function(e) e.FirstName).
                HasComment("First name")

            entity.Property(Function(e) e.LastName).
                HasComment("Last name")

            entity.HasOne(Function(d) d.ContactTypeIdentifierNavigation).
                WithMany(Function(p) p.Contacts).
                HasForeignKey(Function(d) d.ContactTypeIdentifier).
                HasConstraintName("FK_Contacts_ContactType")
        End Sub


    End Class
End Namespace
