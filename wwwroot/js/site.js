(function () {
    // Support Teams themes
    microsoftTeams.initialize();

    // On load, match the current theme
    microsoftTeams.getContext((context) => {
        if (context.theme !== 'default') {
            // For Dark and High contrast, set text to white
            document.body.style.color = '#fff';
            document.body.style.setProperty('--border-style', 'solid');
        }
    });

    // Register event listener for theme change
    microsoftTeams.registerOnThemeChangeHandler((theme) => {
        if (theme !== 'default') {
            document.body.style.color = '#fff';
            document.body.style.setProperty('--border-style', 'solid');
        } else {
            // For default theme, remove inline style
            document.body.style.color = '';
            document.body.style.setProperty('--border-style', 'none');
        }
    });
})();