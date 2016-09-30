import {log} from 'gulp-util';
import * as gulp from 'gulp';
import * as chalk from 'chalk';
import {join} from 'path';

const jade = require('gulp-pug');

gulp.task('pug', () => {
  return gulp.src(['./src/client/**/*pug', '!./src/client/**/_*.pug'])
  .pipe(jade({
    pretty:true
  }))
  .pipe(gulp.dest('./dist/dev/'));
});
