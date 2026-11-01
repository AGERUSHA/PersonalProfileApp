# PersonalProfileApp

1-апта, Тапсырма 1: ASP.NET Core MVC ортасын баптау және жеке ақпараттық визитка жасау.

- Технология: ASP.NET Core MVC, .NET 8.0
- Контроллер: `Controllers/InfoController.cs`
  - `/Info/Index` — басты бет: студент туралы қысқаша мәлімет пен байланыс
  - `/Info/About` — өзім туралы, дағдыларым, байланыс ақпараттары
  - `/Info/Portfolio` — жобаларым, дағдылар және байланыс
- Модель: `Models/StudentProfile.cs`
- Әдепкі маршрут: `{controller=Info}/{action=Index}/{id?}`
- Бақылау сұрақтарының жауаптары: [QUIZ_ANSWERS.md](QUIZ_ANSWERS.md)

## Іске қосу

```bash
dotnet run
```
