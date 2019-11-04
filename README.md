RucksackSolver
====================================

RucksackSolver is an executable to solve the rucksack problem with dynamic programming and as well with the FPTAS.
The executable was written and tested in .Net 4.8.
The corresponding Java implementation can be found here: https://github.com/SeppPenner/RucksackSolver-Java

[![Build status](https://ci.appveyor.com/api/projects/status/ch5dx3a373gh262n?svg=true)](https://ci.appveyor.com/project/SeppPenner/rucksacksolverc)
[![GitHub issues](https://img.shields.io/github/issues/SeppPenner/RucksackSolverC-.svg)](https://github.com/SeppPenner/RucksackSolverC-/issues)
[![GitHub forks](https://img.shields.io/github/forks/SeppPenner/RucksackSolverC-.svg)](https://github.com/SeppPenner/RucksackSolverC-/network)
[![GitHub stars](https://img.shields.io/github/stars/SeppPenner/RucksackSolverC-.svg)](https://github.com/SeppPenner/RucksackSolverC-/stargazers)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://raw.githubusercontent.com/SeppPenner/RucksackSolverC-/master/License.txt)
[![Known Vulnerabilities](https://snyk.io/test/github/SeppPenner/RucksackSolverC-/badge.svg)](https://snyk.io/test/github/SeppPenner/RucksackSolverC-)


## How does the configuration need to look like:
```xml
<?xml version="1.0" encoding="utf-8"?>
<Config xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
	<RucksackObjects>
		<RucksackObject>
			<Price>232</Price>
			<Weight>153</Weight>
		</RucksackObject>
		<RucksackObject>
			<Price>73</Price>
			<Weight>54</Weight>
		</RucksackObject>
		<RucksackObject>
			<Price>201</Price>
			<Weight>191</Weight>
		</RucksackObject>
		<RucksackObject>
			<Price>50</Price>
			<Weight>66</Weight>
		</RucksackObject>
	</RucksackObjects>
</Config>
```

## Screenshot from the executable:
![Screenshot from the executable](https://github.com/SeppPenner/RucksackSolverC-/blob/master/Screenshot.PNG "Screenshot from the executable")

Change history
--------------

* **Version 1.0.1.0 (2019-10-27)** : Updated nuget packages, added GitVersionTask.
* **Version 1.0.0.1 (2019-05-06)** : Updated .Net version to 4.8.
* **Version 1.0.0.0 (2017-04-30)** : 1.0 release.
