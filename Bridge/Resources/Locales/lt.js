Bridge.merge(new System.Globalization.CultureInfo("lt", true), {
    englishName: "Lithuanian",
    nativeName: "lietuvių",

    numberFormat: Bridge.merge(new System.Globalization.NumberFormatInfo(), {
        nanSymbol: "NaN",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "-begalybė",
        positiveInfinitySymbol: "begalybė",
        percentSymbol: "%",
        percentGroupSizes: [3],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ",",
        percentGroupSeparator: " ",
        percentPositivePattern: 0,
        percentNegativePattern: 0,
        currencySymbol: "€",
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

    dateTimeFormat: Bridge.merge(new System.Globalization.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["Sk","Pr","An","Tr","Kt","Pn","Št"],
        abbreviatedMonthGenitiveNames: ["Sau","Vas","Kov","Bal","Geg","Bir","Lie","Rgp","Rgs","Spl","Lap","Grd",""],
        abbreviatedMonthNames: ["Sau","Vas","Kov","Bal","Geg","Bir","Lie","Rgp","Rgs","Spl","Lap","Grd",""],
        amDesignator: "",
        dateSeparator: "-",
        dayNames: ["sekmadienis","pirmadienis","antradienis","trečiadienis","ketvirtadienis","penktadienis","šeštadienis"],
        firstDayOfWeek: 1,
        fullDateTimePattern: "yyyy 'm.' MMMM d 'd.' HH:mm:ss",
        longDatePattern: "yyyy 'm.' MMMM d 'd.'",
        longTimePattern: "HH:mm:ss",
        monthDayPattern: "MMMM d 'd.'",
        monthGenitiveNames: ["sausio","vasario","kovo","balandžio","gegužės","birželio","liepos","rugpjūčio","rugsėjo","spalio","lapkričio","gruodžio",""],
        monthNames: ["sausis","vasaris","kovas","balandis","gegužė","birželis","liepa","rugpjūtis","rugsėjis","spalis","lapkritis","gruodis",""],
        pmDesignator: "",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "yyyy-MM-dd",
        shortestDayNames: ["S","P","A","T","K","Pn","Š"],
        shortTimePattern: "HH:mm",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "yyyy 'm.' MMMM",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});
