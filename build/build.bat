SET MSBUILD="C:\Program Files (x86)\MSBuild\14.0\Bin\amd64\msbuild.exe"

%MSBUILD% build.csproj /property:Configuration=Release;Platform="Any CPU"

pause