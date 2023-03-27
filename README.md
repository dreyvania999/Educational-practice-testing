# Educational practice testing

Данный метод предназначен для определения доступных временных интервалов для записи на консультацию, исходя из занятости консультанта.

## Входные параметры:

Массив TimeSpan startTimes - массив времен начала занятости консультанта;

Массив int durations - массив длительности занятости консультанта;

TimeSpan beginWorkingTime - время начала рабочего дня консультанта;

TimeSpan endWorkingTime - время окончания рабочего дня консультанта;

int consultationTime - длительность консультации.

## Выходные параметры:

Массив строк string[] - массив доступных временных интервалов для записи на консультацию в формате "hh:mm-hh:mm".

## В методе реализован следующий алгоритм:

Проверка корректности входных параметров. Если они некорректны, то метод вернет null.

Создание списка WorkTime для хранения доступных временных интервалов.

Инициализация переменной i, которая используется для определения текущей занятости консультанта.

Итерация по всем возможным временным интервалам с учетом длительности консультации.

Проверка, есть ли занятость консультанта в данный интервал времени. Если есть, то метод пропустит данный интервал.

Добавление доступного временного интервала в список WorkTime.

Преобразование списка WorkTime в массив строк и возврат его в качестве результата работы метода.

Таким образом, данный метод может быть использован для быстрого определения доступных временных интервалов для записи на консультацию, что упрощает работу с клиентами и повышает эффективность работы консультанта.
