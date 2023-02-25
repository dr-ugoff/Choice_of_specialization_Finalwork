# Выбор специализации. IT-специалист (Итоговая проверочная работа)

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Алгоритм решения:
1. Пользователь вводит с клавиатуры произвольное количество строк через запятую
2. Программа проверяет значение каждого элемента (строки) из введенного массива, путем перебора всех элементов с помощью цикла for, на соответствие условию `длина строки меньше или равна трем` и фиксирует количество элементов удовлетворяющих условию (длина массива). 
3. Объявляем новый массив длиной вычисленной в п.2
3. Инициализируем массив таким же способом перебора с помощью цикла for, по условию `длина строки меньше или равна трем` и элементы (строки) из входящего массива, которые удовлетворяют условию, кладем в новый массив
4. Возвращаем новый заполненый массив как результат

### Блок-схема алгоритма:
![Диаграмма](/diagram/Diagram.drawio.png)

### Программа:
Программа находится в папке `program`. Для запуска программы испльзуйте команду через терминал:
```
dotnet run 
```
Введите значения через запятую (без пробела), например:
```
Введите значения через запятую: 1234,1567,-2,computer science,cat
```
Пример вывода программы:
```
[1234, 1567, -2, computer science, cat] -> [-2, cat]
```