Bridge.merge(new System.Globalization.CultureInfo("yo-NG", true), {
    englishName: "Yoruba (Nigeria)",
    nativeName: "Yoruba (Nigeria)",

    numberFormat: Bridge.merge(new System.Globalization.NumberFormatInfo(), {
        nanSymbol: "NaN",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "-Infinity",
        positiveInfinitySymbol: "Infinity",
        percentSymbol: "%",
        percentGroupSizes: [3],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ".",
        percentGroupSeparator: ",",
        percentPositivePattern: 0,
        percentNegativePattern: 0,
        currencySymbol: "₦",
        currencyGroupSizes: [3],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ".",
        currencyGroupSeparator: ",",
        currencyNegativePattern: 9,
        currencyPositivePattern: 2,
        numberGroupSizes: [3],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ".",
        numberGroupSeparator: ",",
        numberNegativePattern: 1
    }),

    dateTimeFormat: Bridge.merge(new System.Globalization.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["Àìk","Ajé","Ìṣg","Ọjr","Ọjb","Ẹti","Àbá"],
        abbreviatedMonthGenitiveNames: ["Oṣu Muharram","Oṣu Safar","Oṣu R Awwal","Oṣu R Aakhir","Oṣu J Awwal","Oṣu J Aakhira","Oṣu Rajab","Oṣu Sha'baan","Oṣu Ramadhan","Oṣu Shawwal","Oṣu Dhul Qa'dah","Oṣu Dhul Hijjah",""],
        abbreviatedMonthNames: ["Oṣu Muharram","Oṣu Safar","Oṣu R Awwal","Oṣu R Aakhir","Oṣu J Awwal","Oṣu J Aakhira","Oṣu Rajab","Oṣu Sha'baan","Oṣu Ramadhan","Oṣu Shawwal","Oṣu Dhul Qa'dah","Oṣu Dhul Hijjah",""],
        amDesignator: "Òwúrọ́",
        dateSeparator: "/",
        dayNames: ["Àìkú","Ajé","Ìṣẹ́gun","Ọjọ́'rú","Ọjọ́'bọ̀","Ẹtì","Àbámẹ́ta"],
        firstDayOfWeek: 0,
        fullDateTimePattern: "dddd, dd MMMM, yyyy h:mm:ss tt",
        longDatePattern: "dddd, dd MMMM, yyyy",
        longTimePattern: "h:mm:ss tt",
        monthDayPattern: "dd MMMM",
        monthGenitiveNames: ["Oṣu Muharram","Oṣu Safar","Oṣu R Awwal","Oṣu R Aakhir","Oṣu J Awwal","Oṣu J Aakhira","Oṣu Rajab","Oṣu Sha'baan","Oṣu Ramadhan","Oṣu Shawwal","Oṣu Dhul Qa'dah","Oṣu Dhul Hijjah",""],
        monthNames: ["Oṣu Muharram","Oṣu Safar","Oṣu R Awwal","Oṣu R Aakhir","Oṣu J Awwal","Oṣu J Aakhira","Oṣu Rajab","Oṣu Sha'baan","Oṣu Ramadhan","Oṣu Shawwal","Oṣu Dhul Qa'dah","Oṣu Dhul Hijjah",""],
        pmDesignator: "Alẹ̀",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "d/M/yyyy",
        shortestDayNames: ["Àì","Aj","Ìṣ","Ọj","Ọb","Ẹt","Àb"],
        shortTimePattern: "h:mm tt",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "MMMM,yyyy",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});
