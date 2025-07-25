# Generating Enemies On Level

## Описание проекта
Проект на Unity, демонстрирующий создание системы спавна врагов с использованием Object Pool, паттерна "спавнер", базового AI для движения врагов и целью для врагов (NavMesh). Подходит как учебный пример для освоения работы с пулом объектов и спавном в Unity.

## Скриншот / демо
*(Добавьте сюда изображение или gif, показывающий работу проекта)*

## Как запустить
1. Клонируйте репозиторий или скачайте архив.
2. Откройте проект в Unity (версии 2022.x или выше).
3. Откройте сцену `Assets/Scenes/SampleScene.unity`.
4. Запустите проект (Play).

## Структура проекта и ключевые скрипты

**Assets/Scripts/**
- **Spawner.cs** — создаёт врагов в заданных точках и с заданным интервалом.
- **EnemyPool.cs** — управляет пулом врагов для оптимизации производительности.
- **Enemy.cs** — логика врага: движение к цели.
- **Mover.cs** — вспомогательный скрипт для движения.
- **Deactivator.cs** — отвечает за деактивацию врагов при выходе за пределы уровня.

**Assets/Material/** — материалы для сцены и объектов.
**Assets/Prefabs/** — префаб врага (Enemy.prefab).
**Assets/Scenes/** — основная сцена SampleScene.
**Assets/Other/** — настройки Input System и туториальные ассеты.
**Assets/Settings/** — рендеринг и профили URP.

## Используемые технологии
- Unity (2022.x или выше)
- Universal Render Pipeline (URP)
- Input System
- Object Pool (для управления врагами)
- NavMesh (для движения врагов к целям)

## Планы и TODO
- Добавить разные типы врагов с разным поведением
- Сделать UI для отображения количества оставшихся врагов
- Добавить эффект появления врага при спавне
- Улучшить навигацию и логику AI

---

> Если проект вам понравился или оказался полезен — можете поставить звезду ⭐ на GitHub!

