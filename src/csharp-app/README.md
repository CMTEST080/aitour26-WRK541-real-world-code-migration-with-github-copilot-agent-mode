C# scaffolding for the weather API (Minimal API)

This folder contains a minimal .NET web app intended as the starting point
for migrating the Python FastAPI application. At this stage it contains only
placeholder endpoints so the project builds and runs. No business logic has
been migrated yet.

Files:
- Program.cs         Minimal API entrypoint with Swagger and placeholder routes
- csharp-app.csproj  Project file (targeting .NET 10)
- data/weather.json  Copy of the Python `weather.json` for later migration

Run (PowerShell):

# Build and run
cd src\csharp-app
dotnet build
dotnet run --urls "http://127.0.0.1:8000"

# Open the Swagger UI in your browser
Start-Process "http://127.0.0.1:8000/swagger"

Testing guidance:
- The project intentionally returns 501 for `/countries` and the detailed
  `/countries/{country}/{city}/{month}` endpoints until migration is performed.
- To validate behavior parity later, run the Python tests against this app by
  setting the BASE_URL environment variable before running pytest:

$env:BASE_URL='http://127.0.0.1:8000'
cd src\python-app
pytest webapp/test_main.py -q

Notes:
- This project targets .NET 10 per your request. Change `<TargetFramework>`
  in the csproj if you need a different SDK version.
