# **Описание решения задачи**

_Условия задачи:_ 
<br>
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

<br>


_Поэтапный процесс решения задачи:_

1. Сначала заводим два строковых массива: 
   - **первый (array1)** - начальный массив с задаными строковыми значениями.
   - **второй (array2)** - новый массив с указаннием длины массива равной длине массива array1.

<br>

2. Затем заводим две переменных:
   - **первая переменная (LimitCheck)** будет использоваться для проверки условия для каждой строки (элемента) массива array1. Значение этой переменной равно 3.
   - **вторая переменная (k)** будет являться счётчиком для элементов заполняемого массива array2

<br>

3. Далее мы заводим **цикл for** и прописываем в условиях, что цикл будет работать по длине массива array1. В цикл for мы вкладываем **условный оператор if** и проверяем каждый элемент array1. 
<br>
Если длина элемента (**array[i].Length**) меньше значения **LimitCheck**, то мы добавляем его в массив **array2** на место, соответствующее текущему значению переменной k (**array2[k]**). 
<br>
Далее мы увеличиваем значение переменной k, возвращаемся к условиям цикла for и повторяем действия, **пока значение i не будет равным длине массива array1**.
   
<br>

1. В последнем блоке мы **поэтапно выводим начальный массив (array1) и конечный массив (array2)**
  
<br> 
