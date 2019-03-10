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
					<div class="grid-y grid-padding-y">
						<div class="cell">
							<ul class="stats-list">
								<li>
									5 <span class="stats-list-label">Shifts Recorded</span>
								</li>
								<li class="stats-list-positive">
									$507 <span class="stats-list-label">Made</span>
								</li>
								<li class="stats-list-negative">
									$289 <span class="stats-list-label">Behind Goal</span>
								</li>
							</ul>
						</div>
						<div class="cell">
							<ul class="bar-graph">
								<li class="bar-graph-axis">
									<div class="bar-graph-label">$150</div>
									<div class="bar-graph-label">$125</div>
									<div class="bar-graph-label">$100</div>
									<div class="bar-graph-label">$75</div>
									<div class="bar-graph-label">$50</div>
									<div class="bar-graph-label">$25</div>
									<div class="bar-graph-label">$0</div>
								</li>
								<li class="bar warning" style="height: 49%;" title="95">
									<div class="dollars">$74</div>
									<div class="description">Monday</div>
								</li>
								<li class="bar secondary" style="height: 57%;" title="90">
									<div class="dollars">$86</div>
									<div class="description">Tuesday</div>
								</li>
								<li class="bar success" style="height: 72%;" title="80">
									<div class="dollars">$108</div>
									<div class="description">Wednesday</div>
								</li>
								<li class="bar success" style="height: 97%;" title="75">
									<div class="dollars">$145</div>
									<div class="description">Thursday</div>
								</li>
								<li class="bar alert" style="height: 0%;" title="40">
									<div class="dollars"></div>
									<div class="description">Friday</div>
								</li>
								<li class="bar secondary" style="height: 63%;" title="40">
									<div class="dollars">$94</div>
									<div class="description">Saturday</div>
								</li>
								<li class="bar alert" style="height: 0%;" title="40">
									<div class="dollars"></div>
									<div class="description">Sunday</div>
								</li>
							</ul>


						</div>
						<div class="cell">
							<div class="grid-x grid-padding-x">
								<div class="small-6 cell">
									
								</div>
							</div>
						</div>
					</div>
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
	<div class="grid-x grid-padding-x">
		<div class="small-12 cell">

		</div>
	</div>
</div>
