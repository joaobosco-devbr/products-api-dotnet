# Products API – ASP.NET Core

API REST desenvolvida em **ASP.NET Core (.NET 8)** para gerenciamento de produtos, com **autenticação JWT**, persistência de dados via **Entity Framework Core + SQLite** e documentação automática com **Swagger (OpenAPI)**.

O projeto foi construído com foco em **boas práticas**, **organização por camadas** e **clareza de código**, sendo ideal para fins educacionais, portfólio e evolução para ambientes de produção.

---

## 🚀 Tecnologias Utilizadas

- .NET 8 / ASP.NET Core
- C#
- Entity Framework Core
- SQLite
- JWT (JSON Web Token)
- Swagger / OpenAPI
- Git & GitHub

---

## 🧱 Arquitetura do Projeto

├── Controllers        → Endpoints HTTP (API)
├── Services           → Regras de negócio
├── Database           → Contexto do banco de dados (EF Core)
├── Models             → Entidades e modelos
├── Migrations         → Controle de versão do banco
├── Program.cs         → Configuração da aplicação
└── appsettings.json   → Configurações gerais

---

## 🔐 Autenticação e Autorização (JWT)

Endpoint de Login  
POST /api/Login

Request Body
{
  "usuario": "admin",
  "senha": "1234"
}

Response (Sucesso)
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}

Uso do Token  
Authorization: Bearer SEU_TOKEN_AQUI

---

## 📦 Endpoints de Produtos (Protegidos)

Listar todos os produtos  
GET /api/Produtos

Buscar produto por ID  
GET /api/Produtos/{id}

Criar produto  
POST /api/Produtos

{
  "nome": "Mouse sem fio",
  "preco": 99.90,
  "estoque": 50
}

Atualizar produto  
PUT /api/Produtos/{id}

Remover produto  
DELETE /api/Produtos/{id}

---

## ▶️ Como Executar o Projeto

Pré-requisitos  
.NET SDK 8+  
Git  

Execução  
git clone https://github.com/joaobosco-devbr/products-api-dotnet.git  
cd products-api-dotnet  
dotnet restore  
dotnet run  

A API ficará disponível em  
http://localhost:5000  

Swagger  
http://localhost:5000/swagger  

---

## 🗄️ Banco de Dados

SQLite  
Entity Framework Core  
Arquivo .db ignorado pelo Git  

Aplicar migrations  
dotnet ef database update  

---

## 🧪 Testes

Swagger UI  
Postman  
Arquivo .http  

---

## ✅ Boas Práticas

Arquitetura em camadas  
Uso de interfaces  
JWT para segurança  
Configurações externas  
Código limpo  
Versionamento com Git  

---

## 🚧 Próximas Melhorias

Controle de acesso por roles  
DTOs para requests e responses  
Testes automatizados  
Deploy em cloud  
CI/CD com GitHub Actions  

---

## 👤 Autor

João Bosco  
https://github.com/joaobosco-devbr  

---

## 📄 Licença

Projeto de uso educacional e demonstrativo.
