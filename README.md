# AgioBank - README

Este projeto é uma aplicação de um banco virtual desenvolvida usando Blazor WebAssembly. O objetivo principal é permitir a criação de contas, autenticação de usuários, e outras operações relacionadas a um ambiente bancário virtual.

## Estrutura de Pastas

- Contexts
	- AccountContext
		- Entities
			- Conta.cs
		- UseCases
			- Create
				- Contracts
					- IServico.cs
					- Servico.cs
					- ICliente.cs
					- Cliente.cs
				- Handler.cs
				- Request.cs
				- Response.cs
				- Validacao.cs
			- Authenticate
				- Contracts
					- IServico.cs
					- Servico.cs
					- ICliente.cs
					- Cliente.cs
				- Handler.cs
				- Request.cs
				- Response.cs
				- Validacao.cs
	- SharedContext
		- Entities
			- Entidade.cs
- Pages
	- Contexts
		- AccountContext
			- UseCases
				- Create
					- Criar.razor
					- Criar.razor.cs


## Descrição das Classes

### AccountContext

#### Entities

- **Conta.cs:** Classe que contém os dados da conta do usuário, herdando de `Entidade.cs`.

#### UseCases

##### Create

- **Contracts**
  - **IServico.cs:** Interface para o serviço de criação de contas.
  - **Servico.cs:** Implementação do serviço de criação de contas.
  - **ICliente.cs:** Interface para a entidade Cliente.
  - **Cliente.cs:** Implementação da entidade Cliente.
- **Handler.cs:** Classe que lida com a execução do caso de uso de criação de contas.
- **Request.cs:** Classe que representa a solicitação para criar uma conta.
- **Response.cs:** Classe que representa a resposta após a criação da conta.
- **Validacao.cs:** Classe responsável pela validação dos dados de entrada para a criação da conta.

##### Authenticate

- **Contracts**
  - **IServico.cs:** Interface para o serviço de autenticação.
  - **Servico.cs:** Implementação do serviço de autenticação.
  - **ICliente.cs:** Interface para a entidade Cliente.
  - **Cliente.cs:** Implementação da entidade Cliente.
- **Handler.cs:** Classe que lida com a execução do caso de uso de autenticação.
- **Request.cs:** Classe que representa a solicitação de autenticação.
- **Response.cs:** Classe que representa a resposta após a autenticação.
- **Validacao.cs:** Classe responsável pela validação dos dados de entrada para a autenticação.

### SharedContext

#### Entities

- **Entidade.cs:** Classe base para todas as entidades nos contextos.

## Páginas

### AccountContext

#### UseCases

##### Create

- **Criar.razor:** Arquivo Razor que representa a interface do usuário para criar uma conta.
- **Criar.razor.cs:** Arquivo de código associado à interface do usuário para criar uma conta.

## Como Contribuir

...

## Como Executar Localmente

...

## Licença

Este projeto está sob a licença XYZ. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---
