# C# .NET 10 WebApi 移行手順

## 概要

このガイドは、開発者が ASP.NET Core Minimal API を使用して Python Weather API を C# .NET 10 に移行するのに役立ちます。 

## 要件

- **Framework**: ASP.NET Core Minimal APIs (.NET 10)
- **JSON Serialization**: System.Text.Json (built-in)
- **API Documentation**: Swashbuckle (OpenAPI/Swagger support)

## 開発ワークフロー

- **Build**: `dotnet build`
- **Run**: `dotnet run`
- **Test**: `dotnet test` (`WeatherApi.Tests` ディレクトリ内のテスト) 
- **API Docs**: 実行時に `/swagger` エンドポイントで利用可能 

## C# API ガイドライン

- `Program.cs` のエンドポイント定義には **Minimal APIs** を使用します 
- すべてのシリアル化には **System.Text.Json** を使用します 
- エンドポイントに Swashbuckle 属性を追加して、Swagger ドキュメントを自動作成します。 
- クラス名はPascalCase、メソッド名はキャメルケースを使用します 
- 例: `src/csharp-app/WeatherApi/Program.cs` を参照してください 

## キー・ファイル

- `src/csharp-app/WeatherApi/Program.cs` - API 構成とエンドポイント 
- `src/csharp-app/WeatherApi.Tests/` - ユニットテスト 
- `src/csharp-app/WeatherApi/Models.cs` - データモデル 
- `src/csharp-app/WeatherApi/weather.json` - サンプルデータ 