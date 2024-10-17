# 02_Conditional_Statements_C
## **Условные операторы** – это конструкции, позволяющие управлять ходом выполнения программы в зависимости от определенных условий. В языке C# присутствует два типа таких конструкций: if…else и switch…case.

**Оператор if**

Конструкция if…else позволяет проверить некоторое условие на истинность и, в зависимости от результата, выполнить тот или иной блок кода.

**Оператор switch**

Конструкция switch…case используется, когда необходимо, в зависимости от конкретного значения переменной или результата некоторой операции, выполнить требуемый блок кода.

Если совпадение найдено, то выполняется код внутри блока case. Блок case может закончится оператором:
*break* – прерывание кода в конструкции switch;
*goto case* – используется если необходимо перейти в другой case;
*return* – завершает выполнение метода и возвращает указанное значение;
*throw* – используется для выброса исключения.
Если среди шаблонов в case не было найдено подходящего, то будет выполнен код в блоке *default*.

**Тернарный оператор**

Результатом вычисления тернарного оператора является одна из двух альтернатив, которая выбирается в зависимости от истинности проверяемого условия. 

## **Циклы** в языках программирования предназначены для построения конструкции, выполняющей заданный блок кода некоторое количество раз, которое определяется тем или иным условием. C# предоставляет четыре разных варианта построения циклов.

**Цикл for**

*Инициализатор* – это выражение, вычисляемое перед выполнением тела цикла. Обычно здесь инициализируется локальная переменная, которая будет использоваться как счетчик.

*Условие* – это выражение, которое проверяется перед каждой новой итерацией цикла. Если значение выражения равно true, то будет выполнено тело цикла, если false – произойдет выход из цикла и выполнится следующая за ним инструкция.

*Итератор* – это выражение, вычисляемое после каждой итерации. Обычно здесь происходит изменение локальной переменной, объявленной в инициализаторе.

**Цикл while**

В этом цикле проверяется условие, и если оно истинно, то выполняется набор операторов внутри тела цикла. 

**Цикл do/while**

Отличие do/while заключается в том, что проверка условия происходит после тела цикла, что приводит к тому, что вне зависимости от условия цикл выполнится хотя бы один раз.

**Цикл foreach**

Оператор foreach используется для обхода коллекций, последовательно переходя от элемента к элементу в цикле. 

Язык C# предоставляет специальные операторы для прерывания выполнения всего цикла и для принудительного завершения текущей итерации с переходом к следующей. Первую задачу решает **оператор break**. Если в программе используется несколько вложенных циклов, то при использованиии break, выход будет выполнен только из того цикла, где этот оператор был вызван. **Оператор continue** принудительно завершает текущую итерацию цикла и переходит к следующей. При этом для цикла while и do/while происходит переход к условному выражению, а в цикле for сначала  вычисляется итерационное выражение, а затем проверяется условие.
