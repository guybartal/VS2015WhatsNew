/// <binding AfterBuild='watch' ProjectOpened='watch' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    less = require('gulp-less');


gulp.task('default', ["copy", "less"]);

gulp.task('copy', function () {
    gulp.src("./wwwroot/lib/bootstrap/dist/**").pipe(gulp.dest("./wwwroot/js/bootstrap"));
    gulp.src("./wwwroot/lib/angular/angular*.{js,map}").pipe(gulp.dest("./wwwroot/js/angular"));
    gulp.src("./wwwroot/lib/react/react*.js").pipe(gulp.dest("./wwwroot/js/react"));

});

gulp.task('less', function () {
    gulp.src("./wwwroot/less/site.less")
        .pipe(less({ compress: true }))
        .pipe(gulp.dest("./wwwroot/less"));
});

gulp.task("watch", ["less"], function () {
    gulp.watch("./wwwroot/less/*.less", ["less"]);
});