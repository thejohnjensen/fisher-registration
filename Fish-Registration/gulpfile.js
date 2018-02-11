var gulp = require("gulp"),
  fs = require("fs"),
  sass = require("gulp-sass");

// other content removed

gulp.task("sass", function () {
  return gulp.src('Styles/site.scss')
    .pipe(sass())
    .pipe(gulp.dest('wwwroot/css'));
});