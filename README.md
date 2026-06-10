# Teleprompter - Web-Based Teleprompter Application

A simple, lightweight web-based teleprompter built with .NET Core MVC.

## Features

- 📝 **Script Editor**: Easy-to-use textarea for inputting your script
- ▶️ **Playback Controls**: Play, pause, and reset buttons for script scrolling
- 🎚️ **Speed Control**: Adjustable scrolling speed (0.5x to 3x)
- 📏 **Font Size Adjustment**: Change text size from 12px to 48px
- 🎨 **Dark Theme**: Eye-friendly dark interface with yellow text
- 💾 **Script Saving**: Save your scripts for later use

## Requirements

- .NET 8.0 or later
- Visual Studio 2022 or VS Code

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/SpikerDallas/Teleprompter.git
   cd Teleprompter
   ```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Open your browser and navigate to `https://localhost:5001`

## Usage

1. **Home Page**: Start by clicking the "Start Teleprompter" button
2. **Edit Script**: Enter or paste your script in the text area at the bottom
3. **Save Script**: Click "Save Script" to save your content
4. **Adjust Display**: Use the font size and speed sliders to customize your experience
5. **Playback**: Use Play, Pause, and Reset buttons to control scrolling

## Project Structure

```
Teleprompter/
├── Controllers/
│   └── HomeController.cs       # Main application controller
├── Models/
│   └── TeleprompterModel.cs    # Data model for teleprompter
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml        # Home page
│   │   └── Teleprompter.cshtml # Main teleprompter interface
│   ├── Shared/
│   │   ├── _Layout.cshtml      # Master layout
│   │   └── _ViewStart.cshtml   # View initialization
│   └── _ViewImports.cshtml     # View imports
├── Program.cs                   # Application startup
├── Teleprompter.csproj         # Project file
└── README.md                    # This file
```

## Future Enhancements

- [ ] Database integration for persistent script storage
- [ ] User authentication and script management
- [ ] Export scripts to various formats (PDF, Word)
- [ ] Remote control via mobile device
- [ ] Mirror display mode for presenter monitors
- [ ] Custom themes and color schemes
- [ ] Keyboard shortcuts
- [ ] Script timing and cue points

## License

MIT License - feel free to use this project for your purposes.

## Contributing

Contributions are welcome! Feel free to open issues and submit pull requests.
