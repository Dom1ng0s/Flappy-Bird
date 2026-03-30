# Flappy Bird Clone 

Este é um clone do clássico jogo Flappy Bird, desenvolvido como projeto prático utilizando **Unity** e **C#**. 

##  Sobre o Projeto
O objetivo deste projeto foi recriar a mecânica principal do Flappy Bird, focando no controle de física 2D, instigação de objetos (spawners) e gerenciamento de estados do jogo.

## 🛠️ Tecnologias Utilizadas
* **Engine:** Unity (2D URP)
* **Linguagem:** C#
* **Controle de Versão:** Git & GitHub

##  Estrutura de Scripts
* `Bird.cs`: Controla o input do jogador, a força do pulo usando `Rigidbody2D` e a detecção de colisões.
* `SpawnPipes.cs` e `Pipes.cs`: Gerenciam a criação contínua dos obstáculos em alturas aleatórias e a movimentação constante para a esquerda.
* `GameController.cs` / `points.cs`: Administram a interface de usuário (UI), a pontuação atual e a condição de Game Over.

##  Como Executar
1. Clone este repositório: `git clone https://github.com/Dom1ng0s/Flappy-Bird.git`
2. Abra o Unity Hub e adicione a pasta do projeto.
3. Abra a cena principal (`SampleScene`) localizada na pasta `Assets/Scenes/`.
4. Dê Play no editor da Unity!
