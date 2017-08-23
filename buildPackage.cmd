@call "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\Tools\VsDevCmd.bat"

MSBuild src\WeixinSDK.Work\WeixinSDK.Work.csproj /t:Clean;Rebuild /p:Configuration=Release
.nuget\nuget.exe pack WeixinSDK.Work.nuspec /o releases

MSBuild src\TencentSDK.Exmail\TencentSDK.Exmail.csproj /t:Clean;Rebuild /p:Configuration=Release
.nuget\nuget.exe pack TencentSDK.Exmail.nuspec /o releases