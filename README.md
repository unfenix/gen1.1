# gen1.1
# Генератор Паролей
# Генератор паролей (Windows Forms)

Это простое приложение на C# с графическим интерфейсом (Windows Forms), которое отображает сгенерированный пароль и предоставляет пользователю возможность скопировать его в буфер обмена.

## Описание

Приложение отображает переданный в форму пароль и позволяет пользователю скопировать его в буфер обмена с помощью кнопки "Скопировать". Оно также включает кнопку "Ок" для закрытия окна. Это приложение может быть полезно для демонстрации генерации паролей и взаимодействия с буфером обмена в приложениях Windows.

### Основные функции:
1. **Отображение пароля** — При передаче пароля в форму, он отображается в **Label**.
2. **Скопировать в буфер обмена** — Кнопка **Скопировать** позволяет скопировать текст пароля в буфер обмена.
3. **Закрытие окна** — Кнопка **Ок** закрывает форму.
## Диаграммы:
[IDEF0 диаграмма A0](https://viewer.diagrams.net/?tags=%7B%7D&lightbox=1&highlight=0000ff&edit=_blank&layers=1&nav=1&title=gen1.png#R%3Cmxfile%3E%3Cdiagram%20name%3D%22%D0%A1%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0%20%E2%80%94%201%22%20id%3D%22uUIk1onNlPaJ4hzw-T1V%22%3E5VlNc5swEP01HNsBBBiOxh9JD20z4%2Bm0PWUYoxg1GDlCjk1%2FfQVIIAmcOI7teFwfNNLTSqB9%2B1ZCNsBoub0h0Sr5imOYGrYZbw0wNmzb8zxWlkBRA47t1MCCoLiGrBaYob%2BQgyZH1yiGuWJIMU4pWqngHGcZnFMFiwjBG9XsAafqU1fRAnaA2TxKu%2BhPFNOkRn170OK3EC0S8WTLC%2BqeZSSM%2BUryJIrxRoLAxAAjgjGta8vtCKal74Rf6nHTHb3NixGY0X0GTLPMXT%2FZ3%2B6%2FW7ezp%2FsfAKfWJz7Lc5Su%2BYKNsWkMrbIMQVW6VTkWdcvwzaruS%2FVJVVZjQ7PC7aocsbkrcCp1yUNCYVZ5iBbC7QSvsxiWb24aINwkiMLZKpqXvRsWZwxL6DJlLYtVu54Qy4KEwq0Ecc%2FcQLyElBTMhPfaDmeJh6k94O1NS3pjk8iEC8OIB9qimbvlglU4HW%2Bgxu1So3sJZvGwjHHWmqdRnqO56hjVizvdBGNFA10nSU5we3wgMALTiKJnVTl9fuFPuMOIvUnDgWWrHABPc22O12QO%2BSg50rWJdDI7E9GILCDtTFTR1Cz7cOYGvaIKHBHxtXgaUZn7iWTaoZ%2FFNmMgzCnBj3CEU0wYnuGMdYdRihZZGReMbMjw8AGlqWYjRUqpFMSy3pAPW6I4Lh%2FTK709w2p%2F9XWYB131NTZy5IFTic8%2FtviYc0jxq2x89gaWAH5XgGn6AhhvZftxIbfuIEFsdSWbLzu%2BDu%2FXs%2F6F6N4xVfatQ3Xv6GGk5%2BYdumc0RoVktioN8lNkhqA%2FM4SS2IGUH4ad%2FKBlBiAhdTkSJcPD680YjuWo%2B7XZzRjeOROGOK8eMWNsEa0TRhAEvF3nC9fxebtNF2WjkBp7J4tLSQK%2Bpl03KNfd%2Fg5LCZ75sUcBq%2F%2BAHbz1PHw1wnV1Qnq2%2BvMK1z7hVu%2FKG731yiZ%2F6RIFgUqd6xy4T%2BsTOfpEpxYleEGUweR6xQd8dddsku4ZxBff%2Ftk%2BZjfWKH9ePuRf1sldseq7fjia9gAA2jGbnRkOPmZrGnzHufvD5Gsf6ZjdHKvFRMHJ5NsbND0Ju9Rt80ld3z7Jt1WsdKS7rKBCrIvWeUfUPRG3%2BzbLVRk65%2Bm4l7KehHs8nTu2ssuyz%2BnXdtr%2FSueHb9PaNVrznX4mnTu9Oh8yh4Arlq6WXE%2B4RbNm%2B%2B9DTVr7Fw6Y%2FAM%3D%3C%2Fdiagram%3E%3C%2Fmxfile%3E)

[IDEF0 диаграмма А1](https://viewer.diagrams.net/?tags=%7B%7D&lightbox=1&highlight=0000ff&edit=_blank&layers=1&nav=1&title=gen2.png#R%3Cmxfile%3E%3Cdiagram%20name%3D%22%D0%A1%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0%20%E2%80%94%201%22%20id%3D%22sujONSz3A7YOonvKzMDq%22%3E7Vpbs5s2EP41fowHSVwf8a15SDuZOZ1J2zfG6NikGDmAY7u%2FvgIJ0AVsH8eYhlM%2FaNAiyZK%2B3dW3KyZovjv9kgb77a8kxPEEGuFpghYTCB0H0bIQnJnA9CATbNIoZCLQCF6ifzAXGlx6iEKcSQ1zQuI82svCNUkSvM4lWZCm5Cg3eyWx%2FK%2F7YIM1wcs6iHXplyjMt0zqQqeRf8TRZlv9M7A99mYXVI35SrJtEJKjIELLCZqnhOTsaXea47jYu2pfWL9Vx9t6YilO8ls64JfE%2Fz1%2B9VDy9bf1xy949W3x1wfA15Hl52rFOKQbwKskzbdkQ5IgXjbSWUoOSYiLYQ1aa9p8ImRPhYAKv%2BI8P3M0g0NOqGib72L%2Bls44Pf%2FB%2B5eVP4vK1Kqqi5P4cnHmNTbXYoKde8BFGTmka3xp4VyXgnSD80vtQA0VVXFMdphOiHZMcRzk0Xd5IgFXtk3drsGDPnBI3gIPG%2Fd7EB%2F4P03oRvigKGfLsnTK0ixLoywXZemWpUV7C1X6CkxcyF8Vz0ZZmpWEll4pAXxAVTtk7I%2FbKMcv%2B6Dc6iN1ADLOfPY4zfHpMmL6BlcdTD4H7j9AZU7HxhqBwWVbwRI9oydMoI6JZkJJ6Be%2Bh9bWcZBl0VreF3kTG2uYQtEewBVrKGufcRrRdeH0zSZyXfXbgRE23mrZ90p2s4Hwf%2FhMIjrBBndbxh26Cp7Mwnkv0e0pAyGoDASVgdg%2BaAOVulEv%2B351QT2qi%2Bu4osJ8MKYGsPvUmqG0ASogmncqAwTe1BN%2FZrtzeZJumD3qBrI01YDv2qE41kNUSPUntaN6ks5YrZTAmwmUAAknvl%2Bd44wGrKpDX2xcS1g5r0oqn2kKSY9yCswsy1PyN56TmBSKkpCkIIZBHG2SQlOpahQKNHuN4lhpI%2BhuQQwiSrV93m0XhWFJMNtohazoj2AWQAbS1omF3aKOqC9eYbcC64vIOBpWNRNktI6WjgT%2BaNGrcfiPoOf05spL1y05c2Nqmug9%2B3I1JlBd8M10QCGZwHmuL3fbfbkrhHQsSluN15BVLNHAhuy1Y2IKbtURHLDH42p2vnqrslyOFy4tLhsaL3hLgNV%2FSut213o9NXWrD2YrHSw3dTE5JRKTmn3qWaoFZ5lFaWm4XUkvBdmepXxfo1OB3SP0u5PeC%2Frtteh3b%2Bkm0BIkFj5GdEIKqy%2FTd3du%2BWgclXa2D%2B2oQMtp%2F7BoH0ApdUgpo%2BGMMRGELAVV407qRweaml67qV9hfxSh4Cw02xcNMk0%2FHsAPQQcZWQnxuymk9JXEPn22ZSqp3w6M1fyRoygKGJqnGI82%2F5%2FNVuuj9Q5blQaqJ%2FikMA12MB1T4jhN6qzmO6JVLqXjeLx2Z8kpdegMbXctebWfOz74YdrfbmW2p1iZaT3XymD7YbcUDrhlFVsoaVC7%2B4Crrr%2F5gy%2BMs6paKilxeO0yfVU1UDrOOpI1z740N10FSkM3widfmndEMZd3cj5eP2kC5erRHdpPtmSw7ze%2FOsgsU2Q3mc2IwbaVqyY4OBl9eCx66%2Fk2FBm1FAjQvXcG6kCaz%2Bz7mOyICd%2F%2Bgdf%2FV8KqnVpK8g8NbafVwO%2FXTsG932loA3neU%2B0UdQSNSDM6MVacXSOyvvBKZLG%2BZq015X3Up5%2BjNXNg9WbmtNp84c1Uq%2FlMHi3%2FBQ%3D%3D%3C%2Fdiagram%3E%3C%2Fmxfile%3E)
## Требования

- .NET Framework 4.7.2 или выше
- Visual Studio (или другая IDE, поддерживающая проекты .NET)

## Установка

1. Клонируйте репозиторий с исходным кодом на ваш локальный компьютер: https://github.com/unfenix/gen1.1
   
2. Откройте проект в Visual Studio или другой IDE, поддерживающей C# и Windows Forms.

3. Соберите проект с помощью меню Сборка > Собрать решение.

4. Запустите приложение.

## Использование

После запуска программы:

В форму передается сгенерированный или заранее заданный пароль.
Этот пароль отображается в Label на форме.
Для того чтобы скопировать пароль в буфер обмена, нажмите кнопку Скопировать.
Для закрытия окна нажмите кнопку Ок.

## Структура проекта

Form2.cs — основная форма приложения, отображает пароль и содержит логику взаимодействия с кнопками.
Form2.Designer.cs — код для дизайна формы.
Program.cs — основной файл программы для запуска приложения.

## Дополнительные сведения

Приложение использует стандартный механизм взаимодействия с буфером обмена в Windows.
Интерфейс приложения нацелен на простоту и понятность, с минимальными элементами управления.
