# 🎭 Playwright C# (.NET) Automation Template

This is a starter repository for End-to-End (E2E) test automation built with **C#**, **Playwright**, and **NUnit**. It follows industry best practices, implementing the **Page Object Model (POM)** architectural pattern.

---

## 🛠️ Prerequisites

Before running this project, ensure you have the following installed on your Mac:

1. **.NET SDK** (Version 8.0 or higher):
   ```bash
   dotnet --version
   ```
2. **Visual Studio Code** with the following extensions installed:
   * **C# Dev Kit** (by Microsoft)
   * **C#** (by Microsoft)

---

## 📂 Project Structure

The project is organized using a clean and scalable directory structure:

```text
PlaywrightTests/
│
├── Pages/                         # Page Objects (UI elements and page-specific actions)
│   ├── LoginPage.cs
│   └── HomePage.cs
│
├── Tests/                         # Test Scripts (E2E scenarios and assertions)
│   └── LoginTest.cs
│
├── .gitignore                     # Git exclusion rules (ignores bin, obj, etc.)
├── .runsettings                   # Global Playwright configuration for .NET
└── template-playwright-csharp.csproj
```

---

## 🚀 Initial Setup

If you have just cloned the repository, execute the following commands in your terminal to set up your environment:

1. **Restore dependencies and build the project:**
   ```bash
   dotnet build
   ```

2. **Install Playwright browsers:**
   ```bash
   dotnet tool run playwright install
   ```
   *(If the command above fails, you can alternatively run: `npx playwright install`)*

---

## 🧪 Running the Tests

You can execute your automated tests on your Mac using any of the methods below:

### 1. Standard Execution (Headless Mode)
Runs the tests silently in the background:
```bash
dotnet test
```

### 2. Visible Browser Execution (Headed Mode 👁️)
Launches the Chromium browser UI so you can watch the test execution in real-time:
```bash
HEADED=1 dotnet test
```

### 3. Generate HTML Test Reports
Creates a detailed, interactive HTML dashboard showcasing test results:
```bash
dotnet test --logger:"html;logFileName=report.html"
```
The report will be saved inside the `TestResults/` folder. Open `report.html` directly from your Finder via any web browser.
