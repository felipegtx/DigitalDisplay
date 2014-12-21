Kanui
=====

Solução para o problema '[digital display](https://github.com/Kanui/QueroSerKanui/tree/master/testes/digital-display)'.

Reconhecimento dos dígitos
------

Por meio da seguinte função de Hash, é possível extrair um identificador único para cada grupo de caracteres que representam um dado dígito no display:

![(((y ^ d) + (x ^ d)) / 3) + (d * y)](http://www4a.wolframalpha.com/Calculate/MSP/MSP60741aid4gd37d296bef000010930b6675fb6530?MSPStoreType=image/gif&s=25&w=108.&h=36. "(((y ^ d) + (x ^ d)) / 3) + (d * y)")

Onde *d* é o resultado da função **GetHashCode** do char em cada uma das posições do display.

Tecnologia utilizada
------

* .Net Framework 4.5 (C#)
* .MSTests
* 




