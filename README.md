# CalculaJurosComposto

## Este projeto consiste em uma atividade que exige a interação entre duas API's, onde a principal irá consultar a API secundária a fim de obter a taxa de juros e em seguida realizará o cálculo aplicando os juros compostos sobre a taxa obtida.

### Tecnologias utilizadas:
- .Net Cores 3.1;
- NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework. O projeto é desenvolvido principalmente pela Microsoft e lançado com a Licença MIT.
    > https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet

### Requisitos para a compilação do projeto:
- Possuir .Net Core 3.1 SDK instalado na máquina local.
    > https://dotnet.microsoft.com/download 
- Possuir instalada a IDE do visual studio ou semelhante.
    > https://visualstudio.microsoft.com/pt-br/vs/ 

### Instruções para a execução do projeto:
- Abrir a IDE do Visual Studio
- Executar o projeto através do IIS Express
- Após inicializar o projeto, a documentação será exibida em uma aba do navegador.

### Instruções para a execução dos testes:
- Abrir a pasta raiz do projeto;
- Acessar a parta "TaxaJurosApi" e executar o seguinte comando no CMD: "dotnet run TaxaJurosApi.csproj";
- Acessar a parta "CalculaJurosApi" e executar o seguinte comando no CMD: "dotnet run CalculaJurosApi.csproj";
- Acessar o gerenciador de testes a partir do Visual Studio.