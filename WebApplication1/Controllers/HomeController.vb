Imports WebApplication1.FModel


Public Class HomeController
    Inherits System.Web.Mvc.Controller


    Function Index() As ActionResult
        Dim x As FModel = New FModel()
        x.List1.Add("One")
        x.List1.Add("Two")
        x.List1.Add("Three")
        x.List1.Add("Four")
        x.List1.Add("Five")
        x.List1.Add("Six")
        x.List1.Add("Seven")
        x.List1.Add("Eight")
        x.List1.Add("Nine")
        x.List1.Add("Ten")




        x.List2.Add("1")
        x.List2.Add("2")
        x.List2.Add("3")
        x.List2.Add("4")
        x.List2.Add("5")
        x.List2.Add("6")
        x.List2.Add("7")
        x.List2.Add("8")
        x.List2.Add("9")
        x.List2.Add("10")


        Return View(x)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
