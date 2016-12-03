Bridge.merge(new System.Globalization.CultureInfo("tk-TM", true), {
    englishName: "Turkmen (Turkmenistan)",
    nativeName: "Türkmen dili (Türkmenistan)",

    numberFormat: Bridge.merge(new System.Globalization.NumberFormatInfo(), {
        nanSymbol: "NaN",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "-tükeniksizlik",
        positiveInfinitySymbol: "tükeniksizlik",
        percentSymbol: "%",
        percentGroupSizes: [3],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ",",
        percentGroupSeparator: " ",
        percentPositivePattern: 1,
        percentNegativePattern: 1,
        currencySymbol: "m.",
        currencyGroupSizes: [3],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ",",
        currencyGroupSeparator: " ",
        currencyNegativePattern: 5,
        currencyPositivePattern: 1,
        numberGroupSizes: [3],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ",",
        numberGroupSeparator: " ",
        numberNegativePattern: 1
    }),

    dateTimeFormat: Bridge.merge(new System.Globalization.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["Ýb","Db","Sb","Çb","Pb","An","Şb"],
        abbreviatedMonthGenitiveNames: ["Ýan","Few","Mart","Apr","Maý","lýun","lýul","Awg","Sen","Okt","Noý","Dek",""],
        abbreviatedMonthNames: ["Ýan","Few","Mart","Apr","Maý","lýun","lýul","Awg","Sen","Okt","Noý","Dek",""],
        amDesignator: "",
        dateSeparator: ".",
        dayNames: ["Ýekşenbe","Duşenbe","Sişenbe","Çarşenbe","Penşenbe","Anna","Şenbe"],
        firstDayOfWeek: 1,
        fullDateTimePattern: "yyyy'-nji ýylyň 'd'-nji 'MMMM HH:mm:ss",
        longDatePattern: "yyyy'-nji ýylyň 'd'-nji 'MMMM",
        longTimePattern: "HH:mm:ss",
        monthDayPattern: "d MMMM",
        monthGenitiveNames: ["Ýanwar","Fewral","Mart","Aprel","Maý","lýun","lýul","Awgust","Sentýabr","Oktýabr","Noýabr","Dekabr",""],
        monthNames: ["Ýanwar","Fewral","Mart","Aprel","Maý","lýun","lýul","Awgust","Sentýabr","Oktýabr","Noýabr","Dekabr",""],
        pmDesignator: "",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "dd.MM.yy 'ý.'",
        shortestDayNames: ["Ý","D","S","Ç","P","A","Ş"],
        shortTimePattern: "HH:mm",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "yyyy 'ý.' MMMM",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});
