@Echo OFF
Echo "Building solution/project file using batch file"

SET SolutionPath=./EasySelectionPatientChatbot.sln
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe %SolutionPath%

SET EXEPath=.\EasySelectionPatientChatbot\bin\Debug\EasySelectionPatientChatbot.exe
call %EXEPath%

Echo End Time - %Time%
Set /p Wait=Build and Run Process Completed...
