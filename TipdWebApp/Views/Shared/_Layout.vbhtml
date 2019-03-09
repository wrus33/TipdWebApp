<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
</head>
<body>

	<div class="container body-content">
		@RenderBody()
		<hr />
		<footer>
		</footer>
	</div>

	@Scripts.Render("~/bundles/jquery")
	@Scripts.Render("~/bundles/foundation")
	@RenderSection("scripts", required:=False)
</body>
	
</html>
<script>
	$('[data-app-dashboard-toggle-shrink]').on('click', function (e) {
		e.preventDefault();
		$(this).parents('.app-dashboard').toggleClass('shrink-medium').toggleClass('shrink-large');
	});


</script>