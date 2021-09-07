
import click
from webscrape_ui import test_subot_dialog

@click.group()
def runuitest():
    pass

@runuitest.command()
def run():
    '''
    Primary executable functionalities
    Runs UItest on SU-bot test
    '''
    test_subot_dialog()