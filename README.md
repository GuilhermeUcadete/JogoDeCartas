# JogoDeCartas
Um framework modular em C# para criação de jogos de cartas.
A solução foi projetada com foco em extensibilidade, clareza arquitetural e reutilização de componentes, permitindo implementar qualquer tipo de jogo baseado em baralho — como Blackjack, Poker, Truco, etc.
## Integrantes do grupo

Eduardo Lima RM554804
Guilherme Ulacco RM558418
Matheus Hostim RM556517

## Enums

Rank.cs
Contém os valores das cartas (A, 2–10, J, Q, K).
Serve como base para qualquer jogo que utilize um baralho tradicional.
Suit.cs
Representa os quatro naipes (♦ ♥ ♣ ♠).
Facilita comparações e ordenações personalizadas.

## Interfaces

IShuffler
Define o comportamento de qualquer algoritmo de embaralhamento.
Isso permite:

- Embaralhamento padrão (aleatório)
- Embaralhamento determinístico (para testes)
- Embaralhamento customizado por jogo

## IGameRule
Define as regras de um jogo específico.
Através dessa interface é possível implementar:

- Regras de pontuação
- Comparação de mãos
- Condições de vitória
- Ações permitidas por jogador
- Dinâmica de turnos


## Models
### Card
Estrutura básica representando:

- Rank
- Suit

É uma classe imutável e segura para comparações.

### Deck
Gerencia um baralho:

- Criação do baralho padrão
- Embaralhamento usando IShuffler
- Compra de cartas
- Reset do deck

### Hand

- Representa a mão de um jogador.
- Permite adicionar e remover cartas facilmente.
- Player
- Representa um jogador individual, contendo:

### Nome

- Mão (Hand)
- Propriedades adicionais que o jogo possa exigir

### Round

- Controla os dados de uma rodada do jogo:

### Jogadores

- Cartas distribuídas
- Estado do turno
- Resultado final

## Services

### DefaultShuffler

Implementação padrão de embaralhamento (randomizado).
Pode ser substituída por qualquer outra classe que implemente IShuffler.

### GameEngine

O núcleo da solução.
Responsável por:

- Inicializar um jogo
- Iniciar e controlar rodadas
- Distribuir cartas
- Aplicar regras via IGameRule
- Determinar vencedores
- Coordenar jogadores e turnos

O motor é totalmente desacoplado de regras específicas — permitindo reutilização para qualquer tipo de jogo.
