# specflow.netcore
Setting up Specflow for DotNetCore in Visual Studio 2017.
Note that this guide will assume that you have Specflow extension already installed in your Visual Studio.

STEP 1: 
1.1 Setup a new unit test (.NET Core) project within your solution.
1.2 By default this will add some NuGet packages to your project and a test class.
Delete the test class, you will not require it.

STEP 2:
In the solution explorer, right click on your solution and select 'Manage NuGet packages for solution'.

STEP 3: 
You will need to install the following packages:
    '<PackageReference Include="Microsoft.AspNetCore.TestHost" Version="2.0.1" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="15.6.0" />
    <PackageReference Include="NUnit" Version="3.9.0" />
    <PackageReference Include="NUnit3TestAdapter" Version="3.9.0" />
    <PackageReference Include="SpecFlow" Version="2.2.1" />
    <PackageReference Include="SpecFlow.NetCore" Version="1.3.1" />
    <PackageReference Include="dotnet-test-nunit" Version="3.4.0-beta-2" />
    <PackageReference Include="System.Configuration.ConfigurationManager" Version="4.5.0-preview1-26216-02" />'

STEP 4: 
Remove any other unnecessary packages installed on the project.

STEP 5: 
5.1 Right click on your Specs project in solution explorer and select 'Edit x.csproj' where x = the name you gave the project in step 1.1. If this option isn't available, you will need to unload the project first.
5.2 Paste the following in the csproj file:
	'<ItemGroup>
	  <DotNetCliToolReference Include="SpecFlow.NetCore" Version="1.3.1" />
	</ItemGroup>'
5.3 In the same file you will need to add a pre-compile script: 
'	<Target Name="PrecompileScript" BeforeTargets="BeforeBuild">
     	<Exec Command="dotnet SpecFlow.NetCore" />
	</Target>'

STEP 6: 
Add a new feature file, generate your step definitions and run the test.


