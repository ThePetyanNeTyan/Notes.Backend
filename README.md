# Notes.Backend
работа с заметками
Разработка ASP NET Core Web API масштабируемая архитектура, entity framework core, automapper, mediatr + cqrs, di, fluentValidation, moddleware, serilog
3 уровня (core, infrastructure, presentation)
core - domain(enterprise логика и типы(можно в разных приложениях))) + application(бизнес логика и типы)
infrastructure - все общение с бд (персистанс уровень)
presentation - веб апи. (зависит от кора, кор не зависит от презенташн)
