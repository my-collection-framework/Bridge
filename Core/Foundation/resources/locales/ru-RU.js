﻿Bridge.merge(new Bridge.CultureInfo("ru-RU"), {
    englishName: "Russian (Russia)",
    nativeName: "русский (Россия)",

    numberFormat: Bridge.merge(new Bridge.NumberFormatInfo(), {
        naNSymbol: "NaN",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "-бесконечность",
        positiveInfinitySymbol: "бесконечность",

        percentSymbol: "%",
        percentGroupSizes: [3],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ",",
        percentGroupSeparator: " ",
        percentPositivePattern: 1,
        percentNegativePattern: 1,

        currencySymbol: "₽",
        currencyGroupSizes: [3],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ",",
        currencyGroupSeparator: " ",
        currencyNegativePattern: 8,
        currencyPositivePattern: 3,

        numberGroupSizes: [3],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ",",
        numberGroupSeparator: " ",
        numberNegativePattern: 1
    }),

    dateTimeFormat: Bridge.merge(new Bridge.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["Вс", "Пн", "Вт", "Ср", "Чт", "Пт", "Сб"],
        abbreviatedMonthGenitiveNames: ["янв", "фев", "мар", "апр", "май", "июн", "июл", "авг", "сен", "окт", "ноя", "дек", ""],
        abbreviatedMonthNames: ["янв", "фев", "мар", "апр", "май", "июн", "июл", "авг", "сен", "окт", "ноя", "дек", ""],
        amDesignator: "",
        dateSeparator: ".",
        dayNames: ["воскресенье", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота"],
        firstDayOfWeek: 1,
        fullDateTimePattern: "d MMMM yyyy 'г.' H:mm:ss",
        longDatePattern: "d MMMM yyyy 'г.'",
        longTimePattern: "H:mm:ss",
        monthDayPattern: "MMMM dd",
        monthGenitiveNames: ["января", "февраля", "марта", "апрелф", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря", ""],
        monthNames:  ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь", ""],
        pmDesignator: "",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "dd.MM.yyyy",
        shortestDayNames: ["Вс", "Пн", "Вт", "Ср", "Чт", "Пт", "Сб"],
        shortTimePattern: "H:mm",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "MMMM yyyy",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffff"
    })
});