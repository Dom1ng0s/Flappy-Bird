> **Learning Project — Unity / C#**
> *Este projeto foi desenvolvido como parte de uma exploração intencional e prática de novas tecnologias no Laboratório TOCA da UFAL.*

###  Flappy Bird Clone

**Exploração prática de Física 2D e Gerenciamento de Estados na Unity**

Este é um clone do clássico jogo Flappy Bird, desenvolvido do zero com o objetivo de aplicar conceitos de programação orientada a objetos em C#, controle de física em tempo real e instanciação de objetos dentro da engine Unity.

---

####  Foco do Aprendizado e Arquitetura

O desenvolvimento não focou apenas em fazer o jogo funcionar, mas em estruturar os scripts de forma limpa e separada por responsabilidades:

* **Gerenciamento de Estados:** Controle transicional fluido entre os estados de "Aguardando", "Jogando" e "Game Over" (via `GameController.cs` e `points.cs`).
* **Física Aplicada:** Uso de `Rigidbody2D` para calcular vetores de força e gravidade no pulo do pássaro de forma realista (via `Bird.cs`).
* **Memory Management (Spawners):** Criação contínua e destruição de obstáculos (canos) em alturas aleatórias, garantindo que o jogo não consuma memória infinita ao longo do tempo (via `SpawnPipes.cs` e `Pipes.cs`).

---

#### 🛠 Stack Tecnológica

* **Engine:** Unity (2D URP)
* **Linguagem:** C#
* **Controle de Versão:** Git & GitHub

---

#### Como Rodar Localmente

**Pré-requisitos**
* Unity Hub instalado.
* Editor da Unity configurado com suporte a projetos 2D.

**Passo a Passo**
1. Clone este repositório: `git clone https://github.com/Dom1ng0s/Flappy-Bird.git`
2. Abra o Unity Hub, clique em "Add" e selecione a pasta do projeto clonado.
3. Com o projeto aberto, navegue até a pasta `Assets/Scenes/` e abra a cena principal (`SampleScene`).
4. Dê Play no editor da Unity para testar!

---

#### 👤 Autor
**Davi Domingos de Oliveira**  
Estudante de Ciência da Computação — UFAL | Backend Developer
