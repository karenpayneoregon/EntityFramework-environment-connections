Imports System
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata
Imports EntityFrameworkCoreLibrary.Models
Imports System.Configuration.ConfigurationManager

Namespace EntityFrameworkCoreLibrary.Contexts
	Partial Public Class NorthWindContext
		Inherits DbContext

		Public Sub New()
		End Sub

        Public Sub New(options As DbContextOptions(Of NorthWindContext))
            MyBase.New(options)
        End Sub

        Public Overridable Property ContactType() As DbSet(Of ContactType)
		Public Overridable Property Contacts() As DbSet(Of Contacts)

        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
            If Not optionsBuilder.IsConfigured Then
                Dim environment = ""

#If Dev Then
                environment = "DevConnection"
#ElseIf Staging Then
				environment = "StagingConnection"
#Else
				environment = "ProductionConnection"
#End If
                optionsBuilder.UseSqlServer(AppSettings(environment))

            End If
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)

            modelBuilder.ApplyConfiguration(New ContactTypeConfiguration())
            modelBuilder.ApplyConfiguration(New ContactsConfiguration())

            OnModelCreatingPartial(modelBuilder)

        End Sub

        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace
