# VetTec [For study purposes] 

# Sistema de Zoológico

Este repositório contém um sistema de gerenciamento de zoológico desenvolvido em C# utilizando Windows Forms com .NET 8. O sistema permite que os usuários se cadastrem, atualizem e editem informações sobre os animais. Além disso, ele utiliza o Seq Datalust para registrar logs e alertar os usuários caso ocorra algum erro específico. O banco de dados utilizado é o SQL e o projeto segue os princípios da Clean Architecture.

This repository contains a zoo management system developed in C# using Windows Forms with .NET 8. The system allows users to register, update, and edit information about animals. Additionally, it uses Seq Datalust to log and alert users in case a specific error occurs. The database used is SQL, and the project follows the principles of Clean Architecture.

## Conceitos Utilizados / Concepts Used

Este projeto utiliza os seguintes conceitos e práticas:

This project uses the following concepts and practices:

- **Idempotência / Idempotency**: Garantia de que operações podem ser repetidas sem efeitos colaterais adicionais.
  - Ensures that operations can be repeated without additional side effects.
- **Logger**: Registro de eventos e erros para monitoramento e depuração.
  - Event and error logging for monitoring and debugging.
- **Alertings**: Notificações de erros e eventos críticos para os usuários.
  - Notifications of errors and critical events to users.
- **Serviços em camadas / Layered Services**: Estruturação do código em camadas lógicas para melhor organização e manutenção.
  - Structuring code into logical layers for better organization and maintainability.
- **Separação de responsabilidades / Separation of Concerns**: Cada componente do sistema tem uma responsabilidade específica e bem definida.
  - Each component of the system has a specific and well-defined responsibility.
- **Injeção de dependências / Dependency Injection**: Gerenciamento de dependências para promover um código mais modular e testável.
  - Managing dependencies to promote more modular and testable code.
- **Clean Code**: Práticas de codificação que promovem legibilidade, simplicidade e manutenção do código.
  - Coding practices that promote readability, simplicity, and maintainability of the code.
- **SOLID**: Princípios de design de software que promovem a escalabilidade e a robustez do código.
  - Software design principles that promote code scalability and robustness.

## Sumário / Summary

- [Pré-requisitos / Prerequisites](#pré-requisitos--prerequisites)
- [Instalação / Installation](#instalação--installation)
- [Estrutura do Projeto / Project Structure](#estrutura-do-projeto--project-structure)
- [Configuração do Seq / Seq Configuration](#configuração-do-seq--seq-configuration)
- [Uso / Usage](#uso--usage)
- [Contribuição / Contribution](#contribuição--contribution)
- [Licença / License](#licença--license)

## Pré-requisitos / Prerequisites

Antes de começar, você precisará das seguintes ferramentas instaladas no seu ambiente:

Before starting, you will need the following tools installed in your environment:

- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Seq](https://datalust.co/seq)

## Instalação / Installation

1. Clone o repositório para o seu ambiente local:

   Clone the repository to your local environment:

   ```bash
   git clone https://github.com/NeemiasBorges/VetTec.git
   cd VetTec
   ```

2. Abra a solução no Visual Studio 2022.

   Open the solution in Visual Studio 2022.

3. Configure a string de conexão com o banco de dados SQL Server no arquivo `appsettings.json` do projeto:

   Configure the connection string to the SQL Server database in the project's `appsettings.json` file:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=seu-servidor;Database=nome-do-banco;User Id=seu-usuario;Password=sua-senha;"
     },
     "Seq": {
       "Url": "http://localhost:5341",
       "ApiKey": "sua-chave-api-seq"
     }
   }
   ```

4. Restaure os pacotes NuGet e construa a solução:

   Restore the NuGet packages and build the solution:

   ```bash
   dotnet restore
   dotnet build
   ```

## Estrutura do Projeto / Project Structure

A solução segue os princípios da Clean Architecture e está organizada da seguinte forma:

The solution follows the principles of Clean Architecture and is organized as follows:

- **Application**: Contém as interfaces dos serviços, casos de uso e DTOs.
  - Contains service interfaces, use cases, and DTOs.
- **Domain**: Contém as entidades e interfaces de repositório.
  - Contains entities and repository interfaces.
- **Infrastructure**: Implementa os repositórios, serviços de log e contexto do banco de dados.
  - Implements repositories, logging services, and database context.
- **Presentation**: Contém os formulários e a lógica de interface do usuário (Windows Forms).
  - Contains forms and user interface logic (Windows Forms).
- **CrossCutting**: Contém classes comuns e utilitários compartilhados entre os diferentes projetos.
  - Contains common classes and utilities shared among different projects.

## Configuração do Seq / Seq Configuration

Para configurar o Seq Datalust, siga as instruções abaixo:

To configure Seq Datalust, follow the instructions below:

1. Baixe e instale o Seq a partir do [site oficial](https://datalust.co/seq).

   Download and install Seq from the [official website](https://datalust.co/seq).

2. Inicie o Seq e configure a URL e a chave da API no arquivo `appsettings.json` conforme mencionado na seção de instalação.

   Start Seq and configure the URL and API key in the `appsettings.json` file as mentioned in the installation section.

## Uso / Usage

1. Inicie a aplicação pelo Visual Studio ou via terminal:

   Start the application via Visual Studio or terminal:

   ```bash
   dotnet run --project src/Presentation
   ```

2. Utilize a interface do usuário para cadastrar, atualizar e editar informações sobre os animais do zoológico.

   Use the user interface to register, update, and edit information about the zoo animals.

3. Verifique os logs no Seq para monitorar eventos e erros.

   Check the logs in Seq to monitor events and errors.

## Contribuição / Contribution

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

Contributions are welcome! Feel free to open issues and pull requests.

Para contribuir:

To contribute:

1. Fork o projeto / Fork the project
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`) / Create a branch for your feature (`git checkout -b feature/new-feature`)
3. Commit suas mudanças (`git commit -am 'Adicione uma nova feature'`) / Commit your changes (`git commit -am 'Add a new feature'`)
4. Push para a branch (`git push origin feature/nova-feature`) / Push to the branch (`git push origin feature/new-feature`)
5. Abra um Pull Request / Open a Pull Request

## Licença / License

This project is licensed under the [MIT License](LICENSE).

---

Se você tiver alguma dúvida ou precisar de ajuda, sinta-se à vontade para abrir uma issue ou entrar em contato.

If you have any questions or need help, feel free to open an issue or get in touch.
