# IAPROJECT
 
Olá.

Essa é a primeira aula de I.A do Curso, e vamos utilizar os conceitos de Navegação para entender um pouco sobbre IA.
Nosso objetivo é pratico, assim vamos focar em produzir diferentes formas de I.A;

O Projeto contém os seguintes Scripts.

IABurra -> Uma Ia que segue um destino, ignorando fisica.

```C#
        Vector3 meuPontoAtual = transform.position;
        Vector3 meuDestino = Destino.transform.position;
        transform.position = Vector3.MoveTowards(meuPontoAtual, meuDestino, 0.01f);
        ```
