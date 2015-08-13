﻿namespace R440O.СостоянияЭлементов.Контур_П
{
    public enum EТумблерКонтроль
    {
        КОНТРОЛЬ_1,
        КОНТРОЛЬ_2
    }

    public enum EТумблерМткПУ
    {
        ПУ,
        МТК
    }

    public enum EТумблерДокументирование
    {
        ОТКЛ,
        ВКЛ
    }

    public enum EТумблерАсинхрСинхр
    {
        СИНХР,
        АСИНХР
    }

    public enum EТумблерРежим
    {
        РЕЖИМ_1,
        РЕЖИМ_2
    }

    public enum EТумблерСеть
    {
        ОТКЛ,
        ВКЛ
    }

    public enum EПереключательПриоритет
    {
        _0,
        _1,
        _2,
        _3,
        _4,
        _5,
        _6,
        _7,
        _8,
        _9
    }

    public enum EПереключательКонтроль
    {
        ОТКЛ = 1,
        _p9B,
        _p5B_от,
        _p12B,
        СЕТЬ,
        _p20B,
        _m20B,
        _p15B,
        _m15B,
        _p9B_резерв
    }
}
