# Payment API Example

## Что реализовано
- ASP.NET Core Web API с REST контроллером
- EF Core + SQLite
- DI для бизнес-логики
- Swagger для тестирования
- Middleware для обработки ошибок

## Как запустить
1. Открой проект в Visual Studio или VS Code
2. Установи зависимости:
   ```
   dotnet restore
   ```
3. Примените миграции:
   ```
   dotnet ef migrations add Init
   dotnet ef database update
   ```
4. Запусти приложение:
   ```
   dotnet run
   ```
5. Перейди на `https://localhost:{port}/swagger`

## Что дальше
- Добавь JWT авторизацию
- Подключи Redis кэш
- Вынеси connection string в `appsettings.json`
