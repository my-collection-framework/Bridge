Bridge.merge(new System.Globalization.CultureInfo("chr-Cher-US", true), {
    englishName: "Cherokee (Cherokee)",
    nativeName: "ᏣᎳᎩ (ᏣᎳᎩ)",

    numberFormat: Bridge.merge(new System.Globalization.NumberFormatInfo(), {
        nanSymbol: "Nan",
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
        currencySymbol: "$",
        currencyGroupSizes: [3],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ".",
        currencyGroupSeparator: ",",
        currencyNegativePattern: 0,
        currencyPositivePattern: 0,
        numberGroupSizes: [3],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ".",
        numberGroupSeparator: ",",
        numberNegativePattern: 1
    }),

    dateTimeFormat: Bridge.merge(new System.Globalization.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["ᏆᏍᎬ","ᏉᏅᎯ","ᏔᎵᏁ","ᏦᎢᏁ","ᏅᎩᏁ","ᏧᎾᎩ","ᏈᏕᎾ"],
        abbreviatedMonthGenitiveNames: ["ᎤᏃᎸ","ᎧᎦᎵ","ᎠᏅᏱ","ᏝᏬᏂ","ᎠᏂᏍ","ᏕᎭᎷ","ᎫᏰᏉ","ᎦᎶᏂ","ᏚᎵᏍ","ᏚᏂᏅ","ᏅᏓᏕ","ᎤᏍᎩ",""],
        abbreviatedMonthNames: ["ᎤᏃᎸ","ᎧᎦᎵ","ᎠᏅᏱ","ᏝᏬᏂ","ᎠᏂᏍ","ᏕᎭᎷ","ᎫᏰᏉ","ᎦᎶᏂ","ᏚᎵᏍ","ᏚᏂᏅ","ᏅᏓᏕ","ᎤᏍᎩ",""],
        amDesignator: "AM",
        dateSeparator: "/",
        dayNames: ["ᎤᎾᏙᏓᏆᏍᎬ","ᎤᎾᏙᏓᏉᏅᎯ","ᏔᎵᏁᎢᎦ","ᏦᎢᏁᎢᎦ","ᏅᎩᏁᎢᎦ","ᏧᎾᎩᎶᏍᏗ","ᎤᎾᏙᏓᏈᏕᎾ"],
        firstDayOfWeek: 0,
        fullDateTimePattern: "dddd, MMMM dd,yyyy h:mm:ss tt",
        longDatePattern: "dddd, MMMM dd,yyyy",
        longTimePattern: "h:mm:ss tt",
        monthDayPattern: "MMMM d",
        monthGenitiveNames: ["ᎤᏃᎸᏔᏅ","ᎧᎦᎵ","ᎠᏅᏱ","ᏝᏬᏂ","ᎠᏂᏍᎬᏘ","ᏕᎭᎷᏱ","ᎫᏰᏉᏂ","ᎦᎶᏂ","ᏚᎵᏍᏗ","ᏚᏂᏅᏗ","ᏅᏓᏕᏆ","ᎤᏍᎩᏱ",""],
        monthNames: ["ᎤᏃᎸᏔᏅ","ᎧᎦᎵ","ᎠᏅᏱ","ᏝᏬᏂ","ᎠᏂᏍᎬᏘ","ᏕᎭᎷᏱ","ᎫᏰᏉᏂ","ᎦᎶᏂ","ᏚᎵᏍᏗ","ᏚᏂᏅᏗ","ᏅᏓᏕᏆ","ᎤᏍᎩᏱ",""],
        pmDesignator: "PM",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "M/d/yyyy",
        shortestDayNames: ["ᏆᏍ","ᏉᏅ","ᏔᎵ","ᏦᎢ","ᏅᎩ","ᏧᎾ","ᏈᏕ"],
        shortTimePattern: "h:mm tt",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "MMMM, yyyy",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});
