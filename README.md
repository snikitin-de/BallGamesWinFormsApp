# BallGamesWinFormsApp

🎮 🎱 Три мини-проекта, написанные в процессе изучения технологии **Windows Forms** в рамках изучения рисования, движения объектов на форме и принципов **ООП**.

## 📁 CatchMeWinFormsApp

<div align="center"><img src="https://github.com/snikitin-de/BallGamesWinFormsApp/assets/25394427/e2a23420-cdaa-4a86-bd3e-319ff64e972d"></div>

### 📄 Описание

#### :question: Правила игры

1. Есть кнопка "Создать", которая создает на форме много разноцветных шариков разного размера, которые начинают двигаться в разные стороны и с разной скоростью.
2. Есть кнопка "Остановить", которая останавливает все созданные шарики. После остановки шариков, выдаётся пользователю количество шариков, которые удалось поймать. Шарик пойман, если он полностью находится на форме. 

#### 🎮 Геймплей

Пример геймплея игры:

![Пример геймплея игры](https://github.com/snikitin-de/BallGamesWinFormsApp/assets/25394427/2f7862ae-af03-41b6-857c-a63bf7a88f7f)

## 📁 CatchMeByMouseWinFormsApp

<div align="center"><img src="https://github.com/snikitin-de/BallGamesWinFormsApp/assets/25394427/9d81acdc-ecd3-4420-897b-0c7ff6d461f1"></div>

### 📄 Описание

#### :question: Правила игры

1. Есть кнопка "Создать", которая создает на форме много разноцветных шариков разного размера, которые начинают двигаться в разные стороны и с разной скоростью.
2. Клик левой кнопки мыши по шарику позволяет "поймать" соответствующий шарик.

Цель игры — "поймать" как можно больше шариков.

#### 🎮 Геймплей

Пример геймплея игры:

![Пример геймплея игры](https://github.com/snikitin-de/BallGamesWinFormsApp/assets/25394427/89ef33b2-25e8-46e5-9acf-eed89a981103)

## 📁 BilliardBallsWinFormsApp

<div align="center"><img src="https://github.com/snikitin-de/BallGamesWinFormsApp/assets/25394427/ccd9d366-c0ba-48a8-a24d-272aa56757d8"></div>

### 📄 Описание

Шарики создаются в рандомном месте с рандомными цветами, размерами и скоростями. Шарики отталкиваются от стенок и генерируют событие столкновения с соответствующей стенкой.

### 💻 Работа программы

Пример работы программы:

![Пример работы программы](https://github.com/snikitin-de/BallGamesWinFormsApp/assets/25394427/51cbed01-043a-4b5a-bd91-807138e3de14)

## 🔧 Техническая часть

* Проект реализован на платформе **Windows Forms**.
* Выполнен с соблюдением принципов **ООП**.
* Реализована работы с событиями.

### 🧩 Архитектура

Структура каталога решения:

![Структура каталога решения](https://github.com/snikitin-de/BallGamesWinFormsApp/assets/25394427/30c3af3e-9591-41c1-99a3-3a8699fa77c3)

Проект "Common" является общей библиотекой классов для следующих проектов:

* [BallGamesWinFormsApp](https://github.com/snikitin-de/BallGamesWinFormsApp)
* [DiffusionWinFormsApp](https://github.com/snikitin-de/DiffusionWinFormsApp)
* [FruitNinjaWinFormsApp](https://github.com/snikitin-de/FruitNinjaWinFormsApp)
* [FireworkWinFormsApp](https://github.com/snikitin-de/FireworkWinFormsApp)

Библиотека содержит общий класс "Ball" от которого наследуются другие шарики со своими особенностями.

### 📝 Работа с событиями

В классе бильярдного шарика "BilliardBall" реализована работа с событиями:

```csharp
 public class BilliardBall : MoveRandomPointBall
 {
     private int ballSize = 50;
     public event EventHandler<HitEventArgs> OnHitted;

     public BilliardBall(int borderX, int borderY) : base(borderX, borderY)
     {
         diameter = ballSize;
     }

     public override void Move()
     {
         base.Move();

         if (centerPoint.X + speed.VX < LeftSide())
         {
             speed.VX = -speed.VX;
             OnHitted.Invoke(this, new HitEventArgs(Side.Left));
         }
         else if (centerPoint.X + speed.VX > RightSide())
         {
             speed.VX = -speed.VX;
             OnHitted.Invoke(this, new HitEventArgs(Side.Right));
         }
         else if (centerPoint.Y + speed.VY < TopSide())
         {
             speed.VY = -speed.VY;
             OnHitted.Invoke(this, new HitEventArgs(Side.Top));
         }
         else if (centerPoint.Y + speed.VY > BottomSide())
         {
             speed.VY = -speed.VY;
             OnHitted.Invoke(this, new HitEventArgs(Side.Bottom));
         }
     }
 }
```

Если шарик столкнулся с одной из стенок, то генерируется событие `OnHitted` в аргументах которого передаётся стенка с которой ударился шарик.

Класс `HitEventArgs`:

```csharp
public class HitEventArgs
{
    public Side Side;

    public HitEventArgs(Side side)
    {
        Side = side;
    }
}
```

В `MainForm` происходит подписывание на событие `OnHitted`, при возникновении которого происходит увеличение значения счётчика количества соударений с соответствующей стенкой:

```csharp
ball.OnHitted += Ball_OnHitted;
```
