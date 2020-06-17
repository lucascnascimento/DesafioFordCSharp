# DesafioFordCSharp
Resolução do desafio da Ford utilizando c#

O ponto de entrada do programa, Program.cs, também está dentro da pasta /DesafioFord.

O arquivo de input está dentro da pasta /DesafioFord.

Para ler o arquivo de input é necessário trocar a variável fileName para o respectivo caminho na máquina que está sendo executado.

No visual studio, ao executar o programa em modo de debug, o arquivo de output.txt será criado na pasta /DesafioFord/bin/Debug

# Problem

## Electrical Crisis

During the electrical crisis in New Zealand this winter (caused by the drought and, as a consequence, the low level of the dams), a scheme of contingency is designed to shut down the country's areas of electricity in a systematically and completely fair way. The country was divided into N regions (Auckland was the number 1 region, and Wellington the number 13). A number, m, was drawn “Randomly”, and the power would be turned off first in region 1 (clearly the fairer initial point) and then each mth region after it, returning to region 1 after N interactions, and ignoring regions already disconnected. For example, if N = 17 and m = 5, the electricity would be turned off in the regions in the following order: 1,6,11,16,5,12,2,9,17,10,4,15,14,3,8,13,7.

The problem is that it is clearly fairer to turn off the power in Wellington last (after all, that's where the power generation headquarters is), so for given N, the “random” number m needs to be carefully chosen in order to region 13 be the last selected one.

Write a program that reads the number of regions and then determines the smallest number m that will ensure that Wellington (region 13) can function while the rest of the country is off.

## Input and Output

The input will consist of a series of rows, each containing a number of regions, N, where 13 <= N <= 100.

The output will consist of a series of rows, one for each input row. Each output row will be the number m according to the scheme shown above.
