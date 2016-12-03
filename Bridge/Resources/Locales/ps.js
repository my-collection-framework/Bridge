Bridge.merge(new System.Globalization.CultureInfo("ps", true), {
    englishName: "Pashto",
    nativeName: "پښتو",

    numberFormat: Bridge.merge(new System.Globalization.NumberFormatInfo(), {
        nanSymbol: "غ ع",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "-∞",
        positiveInfinitySymbol: "∞",
        percentSymbol: "%",
        percentGroupSizes: [3],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ".",
        percentGroupSeparator: ",",
        percentPositivePattern: 2,
        percentNegativePattern: 4,
        currencySymbol: "؋",
        currencyGroupSizes: [3],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ".",
        currencyGroupSeparator: ",",
        currencyNegativePattern: 3,
        currencyPositivePattern: 0,
        numberGroupSizes: [3],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ".",
        numberGroupSeparator: ",",
        numberNegativePattern: 3
    }),

    dateTimeFormat: Bridge.merge(new System.Globalization.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["یکشنبه","دوشنبه","سه‌شنبه","چارشنبه","پنجشنبه","جمعه","شنبه"],
        abbreviatedMonthGenitiveNames: ["محرم","صفر","ربيع الأوّل","ربيع الثاني","جمادى الأول","جمادى الثانى","رجب","شعبان","رمضان","شوّال","ذو القعدة","ذو الحجّة",""],
        abbreviatedMonthNames: ["محرم","صفر","ربيع الأوّل","ربيع الثاني","جمادى الأول","جمادى الثانى","رجب","شعبان","رمضان","شوّال","ذو القعدة","ذو الحجّة",""],
        amDesignator: "غ.م",
        dateSeparator: "/",
        dayNames: ["یکشنبه","دوشنبه","سه‌شنبه","چارشنبه","پنجشنبه","جمعه","شنبه"],
        firstDayOfWeek: 6,
        fullDateTimePattern: "yyyy, dd, MMMM, dddd h:mm:ss tt",
        longDatePattern: "yyyy, dd, MMMM, dddd",
        longTimePattern: "h:mm:ss tt",
        monthDayPattern: "d MMMM",
        monthGenitiveNames: ["محرم","صفر","ربيع الأوّل","ربيع الثاني","جمادى الأول","جمادى الثانى","رجب","شعبان","رمضان","شوّال","ذو القعدة","ذو الحجّة",""],
        monthNames: ["محرم","صفر","ربيع الأوّل","ربيع الثاني","جمادى الأول","جمادى الثانى","رجب","شعبان","رمضان","شوّال","ذو القعدة","ذو الحجّة",""],
        pmDesignator: "غ.و",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "yyyy/M/d",
        shortestDayNames: ["ی","د","س","چ","پ","ج","ش"],
        shortTimePattern: "h:mm tt",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "MMMM yyyy",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});
