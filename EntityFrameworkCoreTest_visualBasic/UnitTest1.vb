Imports System.Text
Imports EntityFrameworkCoreLibrary

Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod>
    Public Async Function TestEntityFrameworkCoreVisualBasic() As Task
        Dim contacts = Await ContactOperations.GetContactsAsync()
        Assert.IsTrue(contacts.Count = 91)
    End Function


End Class