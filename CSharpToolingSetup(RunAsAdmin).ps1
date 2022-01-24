Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
refreshenv
choco install github-desktop -y
choco install dotnetcore-sdk --version=3.1.402 -m -y
choco install vscode -y
choco install vscode-csharpextensions -y
choco install netfx-4.8 -y
refreshenv
code --install-extension  formulahendry.dotnet-test-explorer
