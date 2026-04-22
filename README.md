# DentalAppointment

A simple Windows Forms application for managing dental appointments.

## Project Description

This repository contains a WinForms desktop application that helps schedule and manage dental appointments. The app provides a UI for creating, editing, and deleting appointments and includes basic validation for common input fields (for example, phone numbers).

## Prerequisites

- .NET 10 SDK
- Microsoft Visual Studio Community 2026 (or later) with the ".NET desktop development" workload
- Git (to clone the repository)

Optional:
- A code editor or IDE that supports C# and WinForms development

## Build and Run

Using Visual Studio:
1. Clone the repository:

   `git clone https://github.com/Offranel/DentalAppointment.git`

2. Open `DentalAppointment.sln` in Visual Studio.
3. Restore NuGet packages if prompted and build the solution (Build -> Build Solution).
4. Set the WinForms project as the startup project and press F5 to run.

Using the .NET CLI (if project uses SDK-style format):

1. Open a terminal in the project directory.
2. Run `dotnet build` to build.
3. Run `dotnet run --project DentalAppointment` to launch the application (adjust path if needed).

## Features

- Create, edit and delete appointments
- Input validation for common fields (phone numbers, dates, names)
- Simple and user-friendly WinForms interface

## Screenshots

Add screenshots to the `docs/screenshots` folder and reference them here. Example markdown:

```
![Main UI](docs/screenshots/main-ui.png)
```

Placeholders:

- `docs/screenshots/screenshot1.png` — Main window
- `docs/screenshots/screenshot2.png` — Appointment form

## Configuration

If the app reads or writes files or uses a database later, document configuration settings here (connection strings, file paths, etc.).

## Contributing

Contributions are welcome. To contribute:

1. Fork the repository.
2. Create a feature branch.
3. Make changes and add tests if applicable.
4. Open a pull request describing your change.

## License

Add your chosen license here (for example, MIT). If you don't have a license yet, add one to the repository root as `LICENSE`.

## Contact

If you have questions, open an issue on the repository or contact the project owner.
