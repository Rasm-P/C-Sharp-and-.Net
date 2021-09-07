from setuptools import setup

setup(
    name='runuitest',
    version='0.0.2',
    py_modules=['main'],
    install_requires=[
        'Click == 7.1.2'
    ],
    author='rasmus',
    entry_points='''
        [console_scripts]
        runuitest=cli:runuitest
    '''
)