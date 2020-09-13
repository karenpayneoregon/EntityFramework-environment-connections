Imports EntityFrameworkCoreLibrary
Imports EntityFrameworkCoreTest_visualBasic.EntityFrameworkCoreTest.Classes

<TestClass()> Public Class UnitTest1

    <TestMethod, TestTraits(Trait.EnvironmentConnections)>
    Public Async Function TestEntityFrameworkCoreVisualBasic() As Task
        Dim contacts = Await ContactOperations.GetContactsAsync()
        Assert.IsTrue(contacts.Count = 91)
    End Function

End Class