@Code
	ViewData("Title") = "About"

End Code


<div class="grid-container">
	<div class="grid-x grid-padding-x">
		<div class="small-12 cell">

			<ul class="tabs" data-tabs id="statsTabs">
				<li class="tabs-title is-active"><a href="#weekStats">This Week</a></li>
				<li class="tabs-title"><a href="#monthStats">This Month</a></li>
				<li class="tabs-title"><a href="#yearStats">This Year</a></li>
				<li class="tabs-title"><a href="#allTimeStats">All Time</a></li>
			</ul>

			<div class="tabs-content" data-tabs-content="statsTabs">
				<div class="tabs-panel is-active" id="weekStats">
					<ul class="stats-list">
						<li>
							20 <span class="stats-list-label">Shifts Recorded</span>
						</li>
						<li class="stats-list-positive">
							$1,878 <span class="stats-list-label">Made</span>
						</li>
						<li class="stats-list-negative">
							$289 <span class="stats-list-label">Behind Goal</span>
						</li>
					</ul>
				</div>

				<div class="tabs-panel" id="monthStats">
					<ul class="stats-list">
						<li>
							56 <span class="stats-list-label">Shifts Recorded</span>
						</li>
						<li class="stats-list-positive">
							$9,376 <span class="stats-list-label">Made</span>
						</li>
						<li class="stats-list-negative">
							$78 <span class="stats-list-label">Behind Goal</span>
						</li>
					</ul>
				</div>

			</div>
		</div>
	</div>
</div>
