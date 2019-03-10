Public Class HomeController
	Inherits System.Web.Mvc.Controller

	Function Dashboard() As ActionResult
		Return View()
	End Function

	Function Schedule() As ActionResult
		ViewData("Message") = "Your application description page."

		Return View()
	End Function

	Function TipBook() As ActionResult
		ViewData("Message") = "Your contact page."

		Return View()
	End Function
End Class
