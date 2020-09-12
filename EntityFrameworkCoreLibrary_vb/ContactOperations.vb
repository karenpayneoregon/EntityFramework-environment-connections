Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports EntityFrameworkCoreLibrary.Contexts
Imports EntityFrameworkCoreLibrary.Models
Imports Microsoft.EntityFrameworkCore

Namespace EntityFrameworkCoreLibrary
	Public Class ContactOperations
		Public Shared Async Function GetContactsAsync() As Task(Of List(Of Contacts))
			Return Await Task.Run(Async Function()
				Using context = New NorthWindContext()
					Return Await context.Contacts.Include(Function(contact) contact.ContactTypeIdentifierNavigation).ToListAsync()
				End Using
			End Function)
		End Function
	End Class
End Namespace
