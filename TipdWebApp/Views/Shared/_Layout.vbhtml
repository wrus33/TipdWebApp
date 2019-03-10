<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>@ViewBag.Title - My ASP.NET Application</title>
	@Scripts.Render("~/bundles/jquery")
	@Scripts.Render("~/bundles/foundation")

	@Styles.Render("~/Content/css")
	<link href="https://fonts.googleapis.com/css?family=Lobster|Roboto" rel="stylesheet"></head>
<body>




	@*<!-- mobile nav bar -->
	<div class="title-bar topbar-center-logo-mobile" data-responsive-toggle="topbar-center-logo" data-hide-for="medium">
		<div class="title-bar-left">
			<div class="title-bar-title"><img src="https://placehold.it/100x39" alt="" /></div>
		</div>
		<div class="title-bar-right">
			<button class="menu-icon" type="button" data-toggle="topbar-center-logo"></button>
		</div>
	</div>
	<!-- /mobile nav bar -->*@
	<!-- medium and larger nav bar -->
	<div class="top-bar topbar-center-logo" id="topbar-center-logo">
		<div class="top-bar-left">
			<ul class="menu" id="nav">
				<li><a href="/Home/Dashboard">Dashboard</a></li>
				<li><a href="/Home/Schedule">Schedule</a></li>
				<li><a href="/Home/TipBook">Tip Book</a></li>
			</ul>
		</div>
		<div class="top-bar-center">
			<label id="logo">tipd</label>
		</div>
		<div class="top-bar-right">
			<p>Willy Russell (<a href="#">sign out</a>)</p>
		</div>
	</div>
	<!-- /medium and larger nav bar -->





	<div class="container body-content">
			@RenderBody()

		<footer></footer>
	</div>

	@Scripts.Render("~/bundles/jquery")
	@Scripts.Render("~/bundles/foundation")
	@RenderSection("scripts", required:=False)
</body>
	
</html>
