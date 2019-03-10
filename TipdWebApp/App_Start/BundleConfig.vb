Imports System.Web.Optimization

Public Module BundleConfig
	' For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
	Public Sub RegisterBundles(ByVal bundles As BundleCollection)

		bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
					"~/Scripts/vendor/jquery.js"))


		bundles.Add(New ScriptBundle("~/bundles/foundation").Include(
				  "~/Scripts/app.js",
				  "~/Scripts/vendor/foundation.min.js"))


		bundles.Add(New StyleBundle("~/Content/css").Include(
				  "~/Content/foundation.min.css",
				  "~/Content/app.css"))
	End Sub
End Module

